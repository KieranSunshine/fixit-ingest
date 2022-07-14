﻿using CommandLine;
using Fixit.Parsers;
using Serilog;

namespace FixitIngest
{
	internal static class Program
	{
		static void Main(string[] args)
		{
			Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
			try
			{
				Parser.Default.ParseArguments<Options>(args)
					.WithParsed(RunOptions)
					.WithNotParsed(HandleParserErrors);
			}
			catch (Exception e)
			{
				Log.Error("Encountered unknown exception: {e}", e);
			}
			finally
			{
				Log.CloseAndFlush();	
			}
		}

		static void RunOptions(Options options)
		{
			var docs = File.ReadAllText(options.FilePath);
			var data = DocsParser.Parse(docs);
		}

		static void HandleParserErrors(IEnumerable<Error> errors)
		{
			foreach (var error in errors)
			{
				var msg = error.ToString();
				if (string.IsNullOrWhiteSpace(msg))
					continue;
		
				Log.Error(msg);
			}
		}		
	}
}