using System.Text.Json.Serialization;
using Fixit.Parsers.Model.Internal.Interfaces;

namespace Fixit.Parsers.Model.Internal
{
	public abstract class Descriptor : IDescriptor
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
		
		[JsonPropertyName("mFluidColor")]
		public string FluidColor { get; set; } = string.Empty;
    
		[JsonPropertyName("mGasColor")]
		public string GasColor { get; set; } = string.Empty;
    
		[JsonPropertyName("mResourceSinkPoints")]
		public string ResourceSinkPoints { get; set; } = string.Empty;
	}
}