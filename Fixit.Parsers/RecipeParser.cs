using System.Text.Json;
using Fixit.Parsers.Model.Internal;

namespace Fixit.Parsers;

public static class RecipeParser
{
    public static IEnumerable<Models.Recipe> Parse(List<JsonElement> input)
    {
        var recipes = new List<Models.Recipe>();
        if (!input.Any())
            return recipes;

        foreach (var element in input)
        {
            var recipe = element.Deserialize<Recipe>();
            if (recipe is null)
                continue;

            var dto = recipe.ToDto();
            recipes.Add(dto);
        }

        return recipes;
    }
}