namespace Fixit.Parsers.Model.Internal.Interfaces
{
	public interface IDescriptor
	{
		public string ClassName { get; set; }
		public string DisplayName { get; set; }
		public string Description { get; set; }
		public string AbbreviatedDisplayName { get; set; }
		public string StackSize { get; set; }
		public string CanBeDiscarded { get; set; }
		public string RememberPickUp { get; set; }
		public string EnergyValue { get; set;}
		public string RadioactiveDecay { get; set;}
		public string Form { get; set; }
		public string SmallIcon { get; set; }
		public string PersistentBigIcon { get; set; }
		public string FluidColor { get; set; }
		public string GasColor { get; set; }
		public string ResourceSinkPoints { get; set; }
	}
}