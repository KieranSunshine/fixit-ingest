using Fixit.Parsers.Converters.Interfaces;
using Fixit.Parsers.Model.Internal;

namespace Fixit.Parsers.Converters
{
	public class RecipeConverter: IConverter<Recipe, Fixit.Model.Recipe>
	{
		public Fixit.Model.Recipe ToDto(Recipe input)
		{
			Fixit.Model.Recipe recipe;
			try
			{
				recipe = new()
				{
					FullName = input.FullName,
					DisplayName = input.DisplayName,
					//Ingredients = Ingredients,    // Will be determined later. 
					Product = input.Product,
					ManufacturingMenuPriority = !string.IsNullOrWhiteSpace(input.ManufacturingMenuPriority)
						? double.Parse(input.ManufacturingMenuPriority)
						: null,
					ManufacturingDuration = !string.IsNullOrWhiteSpace(input.ManufacturingDuration)
						? double.Parse(input.ManufacturingDuration)
						: null,
					ManualManufacturingMultiplier = !string.IsNullOrWhiteSpace(input.ManualManufacturingMultiplier)
						? double.Parse(input.ManualManufacturingMultiplier)
						: null,
					ProducedIn = input.ProducedIn,
					RelevantEvents = input.RelevantEvents,
					VariablePowerConsumptionConstant = !string.IsNullOrWhiteSpace(input.VariablePowerConsumptionConstant)
						? double.Parse(input.VariablePowerConsumptionConstant)
						: null,
					VariablePowerConsumptionFactor = !string.IsNullOrWhiteSpace(input.VariablePowerConsumptionFactor)
						? double.Parse(input.VariablePowerConsumptionFactor)
						: null
				};
			}
			catch (Exception e)
			{
				throw;
			}

			return recipe;
		}
	}
}