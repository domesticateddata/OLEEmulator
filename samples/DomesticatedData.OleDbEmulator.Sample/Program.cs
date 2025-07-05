using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DomesticatedData.OleDbEmulator.Sample;

internal class Program
{
    static void Main(string[] args)
    {
        var builder = Host.CreateApplicationBuilder(args);
        
        // Add services to the container
        builder.Services.AddLogging();
        
        using var host = builder.Build();
        
        var logger = host.Services.GetRequiredService<ILogger<Program>>();
        
        logger.LogInformation("OLE DB Emulator Sample Application Started");
        logger.LogInformation("This is a sample application demonstrating the OLE DB Emulator library.");
        
        // Add your sample code here
        
        logger.LogInformation("Sample application completed successfully");
    }
}