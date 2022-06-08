using CommandLine;

namespace FixitIngest
{
	// ReSharper disable once ClassNeverInstantiated.Global
	public class Options
	{
		[Option('f', "file", Required = false, HelpText = "The path to the docs.json file.", Default = "./Docs.json")]
		public string FilePath { get; set; } = string.Empty;
	}
}