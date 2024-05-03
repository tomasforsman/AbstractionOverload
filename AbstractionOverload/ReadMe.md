# AbstractionOverload

AbstractionOverload is a C# project demonstrating effective use of abstractions to create a scalable and maintainable codebase. It features dependency injection, observer patterns, and a factory pattern to handle file operations based on configuration changes dynamically.

## Project Structure

The project is structured into several namespaces and classes focusing on various aspects of file handling and configuration management:

- **Interfaces**: Contains all the interfaces used in the project.
- **Models**: Contains implementations of file readers including synchronous, asynchronous, and secure file reading.
- **Services**: Implements services such as file existence checking, output services, and file reader factory.
- **Program.cs**: The entry point of the application which sets up dependency injection and initializes the application.

## Features

- **Dynamic File Reader Selection**: Depending on the file type specified in the configuration, a suitable file reader (asynchronous, synchronous, or secure) is dynamically chosen and used.
- **Observer Pattern**: Application reacts to changes in configuration dynamically using the observer pattern.
- **Dependency Injection**: Utilizes Microsoft's Dependency Injection container to manage dependencies and application lifecycle.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

- .NET 6.0 SDK or higher

### Installing

First, clone the repository to your local machine:

```bash
git clone https://github.com/yourusername/abstractionoverload.git
cd abstractionoverload
```

Then, build the project using:

```bash
dotnet build
```

### Running the Application

To run the application, use the following command:

```bash
dotnet run --project YourProjectPath
```

Replace `YourProjectPath` with the path to the `.csproj` file.

## Contributing

We welcome contributions from the community and are looking forward to your pull requests (PRs). If you wish to contribute:

1. Fork the repository.
2. Create a feature branch (`git checkout -b feature/AmazingFeature`).
3. Make your changes.
4. Commit your changes (`git commit -m 'Add some AmazingFeature'`).
5. Push to the branch (`git push origin feature/AmazingFeature`).
6. Open a pull request.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.

## Acknowledgments

- Hat tip to anyone whose code was used
- Inspiration
- etc.