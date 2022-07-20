using System.Text.Json.Serialization;

namespace Fixit.Parsers.Model.Internal;

public class Item
{
    [JsonPropertyName("ClassName")]
    public string ClassName { get; set; } = string.Empty;
    
    [JsonPropertyName("mDisplayName")]
    public string DisplayName { get; set; } = string.Empty;
    
    [JsonPropertyName("mDescription")]
    public string Description { get; set; } = string.Empty;

    [JsonPropertyName("mAbbreviatedDisplayName")]
    public string AbbreviatedDisplayName { get; set; } = string.Empty;
    
    [JsonPropertyName("mStackSize")]
    public string StackSize { get; set; } = string.Empty;
    
    [JsonPropertyName("mCanBeDiscarded")]
    public string CanBeDiscarded { get; set; } = string.Empty;
    
    [JsonPropertyName("mRememberPickUp")]
    public string RememberPickUp { get; set; } = string.Empty;
    
    [JsonPropertyName("mEnergyValue")]
    public string EnergyValue { get; set;} = string.Empty;
    
    [JsonPropertyName("mRadioactiveDecay")]
    public string RadioactiveDecay { get; set;} = string.Empty;
    
    [JsonPropertyName("mForm")]
    public string Form { get; set; } = string.Empty;
    
    [JsonPropertyName("mSmallIcon")]
    public string SmallIcon { get; set; } = string.Empty;
    
    [JsonPropertyName("mPersistentBigIcon")]
    public string PersistentBigIcon { get; set; } = string.Empty;
    
    [JsonPropertyName("mSubCategories")] 
    public string SubCategories { get; set; } = string.Empty;
    
    [JsonPropertyName("mMenuPriority")]
    public string MenuPriority { get; set; } = string.Empty;
    
    [JsonPropertyName("mFluidColor")]
    public string FluidColor { get; set; } = string.Empty;
    
    [JsonPropertyName("mGasColor")]
    public string GasColor { get; set; } = string.Empty;
    
    [JsonPropertyName("mResourceSinkPoints")]
    public string ResourceSinkPoints { get; set; } = string.Empty;
    
    [JsonPropertyName("mBuildMenuPriority")]
    public string BuildMenuPriority { get; set; } = string.Empty;

    public Models.Item ToDto()
    {
        return new()
        {
            DisplayName = DisplayName,
            Description = Description,
            AbbreviatedDisplayName = AbbreviatedDisplayName,
            StackSize = StackSize,
            CanBeDiscarded = bool.Parse(CanBeDiscarded),
            RememberPickUp = bool.Parse(RememberPickUp),
            EnergyValue = double.Parse(EnergyValue),
            RadioactiveDecay = double.Parse(RadioactiveDecay),
            Form = Form,
            SmallIcon = SmallIcon,
            PersitentBigIcon = PersistentBigIcon,
            SubCategories = SubCategories,
            MenuPriority = double.Parse(MenuPriority),
            FluidColor = FluidColor,
            GasColor = GasColor,
            ResourceSinkPoints = int.Parse(ResourceSinkPoints),
            BuildMenuPriority = double.Parse(BuildMenuPriority)
        };
    }
}