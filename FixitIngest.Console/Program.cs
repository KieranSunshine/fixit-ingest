using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Events;

namespace FixitIngest.Console // Note: actual namespace depends on the project name.
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
                .Enrich.FromLogContext()
                .WriteTo.Console()
                .CreateLogger();

            try
            {
                await Host.CreateDefaultBuilder(args)
                    .UseSerilog()
                    .ConfigureServices((context, services) =>
                    {
                        services.AddHostedService<IngestService>();
                    })
                    .RunConsoleAsync();
            }
            catch (Exception e)
            {
                Log.Error(e, "An error occurred.");
                throw;
            }
            finally
            {
                Log.CloseAndFlush();    
            }
        }
    }
}