using Fixit.Parsers.Converters.Interfaces;
using Fixit.Parsers.Model.Internal;

namespace Fixit.Parsers.Converters
{
	public class ResourceConverter: IConverter<Resource, Fixit.Model.Resource>
	{
		public Fixit.Model.Resource ToDto(Resource input)
		{
			return new()
			{
				ClassName = input.ClassName,
				DisplayName = input.DisplayName,
				Description = input.Description,
				DecalSize = double.Parse(input.DecalSize),
				PingColor = input.PingColor,
				CollectSpeedMultiplier = double.Parse(input.CollectSpeedMultiplier),
				ManualMiningAudioName = input.ManualMiningAudioName,
				AbbreviatedDisplayName = input.AbbreviatedDisplayName,
				StackSize = input.StackSize,
				CanBeDiscarded = bool.Parse(input.CanBeDiscarded),
				RememberPickUp = bool.Parse(input.RememberPickUp),
				EnergyValue = double.Parse(input.EnergyValue),
				RadioactiveDecay = double.Parse(input.RadioactiveDecay),
				Form = input.Form,
				SmallIcon = input.SmallIcon,
				PersitentBigIcon = input.PersistentBigIcon,
				FluidColor = input.FluidColor,
				GasColor = input.GasColor,
				ResourceSinkPoints = int.Parse(input.ResourceSinkPoints),
			};
		}
	}
}