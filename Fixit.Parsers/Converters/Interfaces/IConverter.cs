namespace Fixit.Parsers.Converters.Interfaces
{
	public interface IConverter
	{
		public TOutput ToDto<TInput, TOutput>(TInput input);
	}
}