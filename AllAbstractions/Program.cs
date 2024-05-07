using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Serilog;

// Interfaces

// Implementations

class Program
{
    static async Task Main(string[] args)
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Console()
            .CreateLogger();

        try
        {
            var model = new FileModel { FilePath = "example.txt" };
            var view = new ConsoleView();
            var observer = new ConsoleObserver();
            model.RegisterObserver(observer);

            var fileReader = new CachedFileReader(new BasicFileReader());
            var controller = new FileController(model, view);

            await controller.ReadFileAsync(fileReader);  // Read and potentially cache the file
            await controller.ReadFileAsync(fileReader);  // Possibly fetch from cache
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Unhandled exception.");
        }
        finally
        {
            Log.CloseAndFlush();
        }
    }
}