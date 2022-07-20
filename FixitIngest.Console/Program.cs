using Fixit.Parsers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FixitIngest.Console // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using var host = Host.CreateDefaultBuilder(args).Build();
            var config = host.Services.GetRequiredService<IConfiguration>();

            var path = config.GetValue<string>("Configuration:DocsFilePath");
            if (string.IsNullOrWhiteSpace(path) || !Path.IsPathFullyQualified(path))
            {
                throw new Exception("Configuration error"); // make Configuration Exception.
            }

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

            await host.RunAsync();
        }
    }
}