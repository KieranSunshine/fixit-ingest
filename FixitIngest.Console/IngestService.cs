using Fixit.Parsers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace FixitIngest.Console
{
	public class IngestService : IHostedService
	{
		private readonly ILogger<IngestService> _logger;
		private readonly IHostApplicationLifetime _applicationLifetime;
		private readonly IConfiguration _configuration;
		
		public IngestService(
			ILogger<IngestService> logger,
			IHostApplicationLifetime applicationLifetime,
			IConfiguration configuration)
		{
			_logger = logger;
			_applicationLifetime = applicationLifetime;
			_configuration = configuration;
		}
		
		public Task StartAsync(CancellationToken cancellationToken)
		{
			_applicationLifetime.ApplicationStarted.Register(() =>
			{
				Task.Run(async () =>
				{
					try
					{
						await Ingest();
					}
					catch (Exception e)
					{
						_logger.LogError(e, "Unhandled Exception!");
					}
					finally
					{
						_applicationLifetime.StopApplication();
					}
				}, cancellationToken);
			});

			
			return Task.CompletedTask;
		}

		public Task StopAsync(CancellationToken cancellationToken)
		{
			return Task.CompletedTask;
		}

		private async Task Ingest()
		{
			var path = _configuration.GetValue<string>("Configuration:DocsFilePath");
			if (string.IsNullOrWhiteSpace(path))
			{
				path = Path.GetFullPath("Docs.json");
			}
			else
			{
				if (!Path.IsPathFullyQualified(path))
					throw new Exception("Configuration error"); // make Configuration Exception.
			}

			_logger.LogInformation("Reading Docs.json from path, '{path}'.", path);
			string docs;
			try
			{
				docs = await File.ReadAllTextAsync(path);
			}
			catch (Exception e)
			{
				System.Console.WriteLine(e);
				throw;
			}

			var data = DocsParser.Parse(docs);

			var breaker = true;
		}
	}
}