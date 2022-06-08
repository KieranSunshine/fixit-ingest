using System.Text.Json;
using CommandLine;
using FixitIngest.Model;
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
			string data;
			using (var reader = new StreamReader(options.FilePath))
			{
				data = reader.ReadToEnd();
			}

			IReadOnlyCollection<ClassGrouping>? groupings;
			try
			{
				groupings = JsonSerializer.Deserialize<IReadOnlyCollection<ClassGrouping>>(data);
			}
			catch (Exception e) when (e is ArgumentNullException or JsonException or NotSupportedException)
			{
				Log.Error("Failed to deserialize Docs.json file, {e}", e);
				throw;
			}

			if (groupings is null)
				throw new ArgumentNullException(); // TODO: throw appropriate error.

			var items = groupings.FirstOrDefault(t => t.NativeClass == "Class'/Script/FactoryGame.FGItemDescriptor'");
			if (items is null)
				throw new ArgumentNullException(); // TODO: throw appropriate error.
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