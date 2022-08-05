using System.Text.Json.Serialization;

namespace Fixit.Parsers.Model.Internal;

public class Item : Descriptor
{
    [JsonPropertyName("mSubCategories")] 
    public string SubCategories { get; set; } = string.Empty;
    
    [JsonPropertyName("mMenuPriority")]
    public string MenuPriority { get; set; } = string.Empty;

    [JsonPropertyName("mBuildMenuPriority")]
    public string BuildMenuPriority { get; set; } = string.Empty;

}