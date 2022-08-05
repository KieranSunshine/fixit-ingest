using Fixit.Parsers.Converters.Interfaces;
using Fixit.Parsers.Model.Internal;

namespace Fixit.Parsers.Converters
{
	public class ItemConverter: IConverter
	{
		public TOutput ToDto<Item, TOutput>(Item input) => throw new NotImplementedException();

		// public Fixit.Model.Item ToDto(Item input)
		// {
		// 	Fixit.Model.Item item;
		// 	try
		// 	{
		// 		item = new()
		// 		{
		// 			ClassName = input.ClassName,
		// 			DisplayName = input.DisplayName,
		// 			Description = input.Description,
		// 			AbbreviatedDisplayName = input.AbbreviatedDisplayName,
		// 			StackSize = input.StackSize,
		// 			CanBeDiscarded = bool.Parse(input.CanBeDiscarded),
		// 			RememberPickUp = bool.Parse(input.RememberPickUp),
		// 			EnergyValue = double.Parse(input.EnergyValue),
		// 			RadioactiveDecay = double.Parse(input.RadioactiveDecay),
		// 			Form = input.Form,
		// 			SmallIcon = input.SmallIcon,
		// 			PersitentBigIcon = input.PersistentBigIcon,
		// 			SubCategories = input.SubCategories,
		// 			MenuPriority = !string.IsNullOrWhiteSpace(input.MenuPriority) ? double.Parse(input.MenuPriority) : null,
		// 			FluidColor = input.FluidColor,
		// 			GasColor = input.GasColor,
		// 			ResourceSinkPoints = int.Parse(input.ResourceSinkPoints),
		// 			BuildMenuPriority = !string.IsNullOrWhiteSpace(input.BuildMenuPriority) ? double.Parse(input.BuildMenuPriority) : null
		// 		};
		// 	}
		// 	catch (Exception e)
		// 	{
		// 		throw;
		// 	}
		//
		// 	return item;
		// }
	}
}