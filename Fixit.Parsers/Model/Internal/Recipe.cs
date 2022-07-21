using System.Text.Json.Serialization;

namespace Fixit.Parsers.Model.Internal;

public class Recipe
{
    [JsonPropertyName("ClassName")]
    public string ClassName { get; set; }
    
    [JsonPropertyName("FullName")]
    public string FullName { get; set; }
    
    [JsonPropertyName("mDisplayName")]
    public string DisplayName { get; set; }
    
    [JsonPropertyName("mIngredients")]
    public string Ingredients { get; set; }
    
    [JsonPropertyName("mProduct")]
    public string Product { get; set; }
    
    [JsonPropertyName("mManufacturingMenuPriority")]
    public string ManufacturingMenuPriority { get; set; }

    [JsonPropertyName("mManufacturingDuration")]
    public string ManufacturingDuration { get; set; }
    
    [JsonPropertyName("mManualManufacturingMultiplier")]
    public string ManualManufacturingMultiplier { get; set; }
    
    [JsonPropertyName("mProducedIn")]
    public string ProducedIn { get; set; }
    
    [JsonPropertyName("mRelevantEvents")]
    public string RelevantEvents { get; set; }
    
    [JsonPropertyName("mVariablePowerConsumptionConstant")]
    public string VariablePowerConsumptionConstant { get; set; }
    
    [JsonPropertyName("mVariablePowerConsumptionFactor")]
    public string VariablePowerConsumptionFactor { get; set; }

    public Models.Recipe ToDto()
    {
        Models.Recipe recipe;
        try
        {
            recipe = new()
            {
                FullName = FullName,
                DisplayName = DisplayName,
                Ingredients = Ingredients,
                Product = Product,
                ManufacturingMenuPriority = !string.IsNullOrWhiteSpace(ManufacturingMenuPriority)
                    ? double.Parse(ManufacturingMenuPriority)
                    : null,
                ManufacturingDuration = !string.IsNullOrWhiteSpace(ManufacturingDuration)
                    ? double.Parse(ManufacturingDuration)
                    : null,
                ManualManufacturingMultiplier = !string.IsNullOrWhiteSpace(ManualManufacturingMultiplier)
                    ? double.Parse(ManualManufacturingMultiplier)
                    : null,
                ProducedIn = ProducedIn,
                RelevantEvents = RelevantEvents,
                VariablePowerConsumptionConstant = !string.IsNullOrWhiteSpace(VariablePowerConsumptionConstant)
                    ? double.Parse(VariablePowerConsumptionConstant)
                    : null,
                VariablePowerConsumptionFactor = !string.IsNullOrWhiteSpace(VariablePowerConsumptionFactor)
                    ? double.Parse(VariablePowerConsumptionFactor)
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