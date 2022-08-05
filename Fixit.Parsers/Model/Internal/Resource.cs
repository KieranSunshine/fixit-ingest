using System.Text.Json.Serialization;

namespace Fixit.Parsers.Model.Internal
{
	public class Resource : Descriptor
	{
		[JsonPropertyName("mDecalSize")]
		public string DecalSize { get; set; } = string.Empty;

		[JsonPropertyName("mPingColor")]
		public string PingColor { get; set; } = string.Empty;

		[JsonPropertyName("mCollectSpeedMultiplier")]
		public string CollectSpeedMultiplier { get; set; } = string.Empty;

		[JsonPropertyName("mManualMiningAudioName")]
		public string ManualMiningAudioName { get; set; } = string.Empty;
	}
}