using System.Text.Json.Serialization;

namespace Fixit.Models;

public record Item
{
    [JsonPropertyName("mDisplayName")]
    public string DisplayName { get; set; }
    
    [JsonPropertyName("mDescription")]
    public string Description { get; set; }
    
    [JsonPropertyName("mAbbreviatedDisplayName")]
    public string AbbreviatedDisplayName { get; set; }
    
    [JsonPropertyName("mStackSize")]
    public string StackSize { get; set; }
    
    [JsonPropertyName("mCanBeDiscarded")]
    public bool CanBeDiscarded { get; set; }

    [JsonPropertyName("mRememberPickUp")]
    public bool RememberPickUp { get; set; }

    [JsonPropertyName("mEnergyValue")]
    public double EnergyValue { get; set;}

    [JsonPropertyName("mRadioactiveDecay")]
    public double RadioactiveDecay { get; set;}

    [JsonPropertyName("mForm")]
    public string Form { get; set; }

    [JsonPropertyName("mSmallIcon")]
    public string SmallIcon { get; set; }
    
    [JsonPropertyName("mPersistentBigIcon")]
    public string PersitentBigIcon { get; set; }
    
    [JsonPropertyName("mSubCategories")] 
    public string SubCategories { get; set; }
    
    [JsonPropertyName("mMenuPriority")]
    public double MenuPriority { get; set; }
    
    [JsonPropertyName("mFluidColor")]
    public string FluidColor { get; set; }
    
    [JsonPropertyName("mGasColor")]
    public string GasColor { get; set; }
    
    [JsonPropertyName("mResourceSinkPoints")]
    public int ResourceSinkPoints { get; set; }
    
    [JsonPropertyName("mBuildMenuPriority")]
    public double BuildMenuPriority { get; set; }
}