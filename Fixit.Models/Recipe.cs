namespace Fixit.Models;

public class Recipe
{
    public string FullName { get; set; }
    public string DisplayName { get; set; }
    public string Ingredients { get; set; }
    public string Product { get; set; }
    public double? ManufacturingMenuPriority { get; set; }
    public double? ManufacturingDuration { get; set; }
    public double? ManualManufacturingMultiplier { get; set; }
    public string ProducedIn { get; set; }
    public string RelevantEvents { get; set; }
    public double? VariablePowerConsumptionConstant { get; set; }
    public double? VariablePowerConsumptionFactor { get; set; }
}