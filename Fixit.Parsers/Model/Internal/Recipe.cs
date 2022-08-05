using System.Text.Json.Serialization;

namespace Fixit.Parsers.Model.Internal;

public class Recipe
{
    [JsonPropertyName("ClassName")]
    public string ClassName { get; set; } = string.Empty;
    
    [JsonPropertyName("FullName")]
    public string FullName { get; set; } = string.Empty;

    [JsonPropertyName("mDisplayName")]
    public string DisplayName { get; set; } = string.Empty;

    [JsonPropertyName("mIngredients")]
    public string Ingredients { get; set; } = string.Empty;

    [JsonPropertyName("mProduct")]
    public string Product { get; set; } = string.Empty;

    [JsonPropertyName("mManufacturingMenuPriority")]
    public string ManufacturingMenuPriority { get; set; } = string.Empty;

    [JsonPropertyName("mManufacturingDuration")]
    public string ManufacturingDuration { get; set; } = string.Empty;

    [JsonPropertyName("mManualManufacturingMultiplier")]
    public string ManualManufacturingMultiplier { get; set; } = string.Empty;

    [JsonPropertyName("mProducedIn")]
    public string ProducedIn { get; set; } = string.Empty;

    [JsonPropertyName("mRelevantEvents")]
    public string RelevantEvents { get; set; } = string.Empty;

    [JsonPropertyName("mVariablePowerConsumptionConstant")]
    public string VariablePowerConsumptionConstant { get; set; } = string.Empty;

    [JsonPropertyName("mVariablePowerConsumptionFactor")]
    public string VariablePowerConsumptionFactor { get; set; } = string.Empty;
}