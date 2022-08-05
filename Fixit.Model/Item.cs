namespace Fixit.Model;

public record Item
{
    public string ClassName { get; set; }
    public string DisplayName { get; set; }
    public string Description { get; set; }
    public string AbbreviatedDisplayName { get; set; }
    public string StackSize { get; set; }
    public bool CanBeDiscarded { get; set; }
    public bool RememberPickUp { get; set; }
    public double EnergyValue { get; set;}
    public double RadioactiveDecay { get; set;}
    public string Form { get; set; }
    public string SmallIcon { get; set; }
    public string PersitentBigIcon { get; set; }
    public string SubCategories { get; set; }
    public double? MenuPriority { get; set; }
    public string FluidColor { get; set; }
    public string GasColor { get; set; }
    public int ResourceSinkPoints { get; set; }
    public double? BuildMenuPriority { get; set; }
}