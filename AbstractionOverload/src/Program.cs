using AbstractionOverload.Interfaces;
using AbstractionOverload.Services;
using Microsoft.Extensions.DependencyInjection;

internal class Program
{
    private static void Main(string[] args)
    {
        // Setup the Dependency Injection container.
        var serviceProvider = new ServiceCollection()
            .AddSingleton<IConfigurationService, ConfigurationService>()  // Register ConfigurationService as a singleton to maintain a single instance throughout the app lifecycle.
            .AddSingleton<IFileReaderFactory, FileReaderFactory>()         // Register FileReaderFactory as a singleton to provide a consistent factory method across the application.
            .AddSingleton<IOutputService, ConsoleOutputService>()          // Register ConsoleOutputService as a singleton to handle all console outputs.
            .AddSingleton<IFileExistenceChecker, FileExistenceChecker>()   // Register FileExistenceChecker as a singleton to check the existence of files whenever required.
            .AddTransient<Application>()                                   // Register the Application class as transient, creating a new instance each time it's needed.
            .BuildServiceProvider();                                       // Build the service provider which will resolve dependencies.

        // Resolve IConfigurationService from the service provider and cast it to ConfigurationService.
        var configService = serviceProvider.GetService<IConfigurationService>() as ConfigurationService;
        // Resolve the Application instance from the service provider.
        var app = serviceProvider.GetService<Application>();

        // Register the application as an observer to the configuration service to receive updates.
        configService.RegisterObserver(app);

        // Simulate a change in configuration by changing the file type.
        Console.WriteLine("Changing the file type...");
        configService.SetFileType("Secure");  // This change triggers the observer's update logic, could be based on user input or other conditions in a real application.

        // Run the application logic.
        app.Run();
    }
}
