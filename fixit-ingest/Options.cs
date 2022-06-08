using CommandLine;

namespace fixit_ingest
{
	// ReSharper disable once ClassNeverInstantiated.Global
	public class Options
	{
		[Option('f', "file", Required = false, HelpText = "The path to the docs.json file.", Default = "./")]
		public string FilePath { get; set; } = string.Empty;
	}
}