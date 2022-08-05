using System.Text.RegularExpressions;
using Fixit.Model;
using Fixit.Parsers.Model.Internal.Interfaces;
using Docs = Fixit.Parsers.Model.Internal.Docs;
using Recipe = Fixit.Model.Recipe;

namespace Fixit.Parsers.Mappers
{
	public static class RecipeMapper
	{
		public static List<Recipe> Map(Docs docs)
		{
			var recipes = new List<Recipe>();
			if (!docs.Recipes.Any() || !docs.Items.Any())
				return recipes;

			var ingredientCollection = new List<IEnumerable<IDescriptor>> { docs.Items, docs.Equipment, docs.Resources }
				.SelectMany(i => i)
				.ToList();
			
			foreach (var recipe in docs.Recipes)
			{
				 var dto = recipe.ToDto();

				 // TODO: Extract to RecipeMapper class. Call from ToDto method.
				 var regex = new Regex(@"\([^()]*\),?");
				 var ingredients = regex.Matches(recipe.Ingredients).Select(m => m.Value.Trim('(', ')', ',').Split(','));
				
				 // Process all ingredients at once? Would reduce item iterations.
				 foreach(var ingredient in ingredients)
				 {
				     var properties = ingredient.Select(p => p.Split('=')).ToDictionary(k => k[0], v => v[1]);
				
				     // Item
				     var itemClass = properties.GetValueOrDefault("ItemClass");
				     if (string.IsNullOrWhiteSpace(itemClass))
				         throw new Exception("Ingredient does not have an ItemClass property");
				     
				     var itemName = itemClass.Substring(itemClass.LastIndexOf('.')).Trim('.', '"', '\''); // TODO: Extract this to a BlueprintGeneratedClass helper?
				     var item = ingredientCollection.FirstOrDefault(i => i.ClassName == itemName)?.ToDto();
				     if (item is null)
						throw new Exception($"Could not determine item from ItemClass property, '{itemName}'.");
				     
				     // Amount
				     var amount = properties.GetValueOrDefault("Amount");
				     if (string.IsNullOrWhiteSpace(amount))
				         throw new Exception("Ingredient does not have an Amount property");
				
				     var ingredientDto = new Ingredient(item, int.Parse(amount));
				     dto.Ingredients.Add(ingredientDto);
				     
				     recipes.Add(dto);
				 }
			}

			return recipes;
		}
	}
}