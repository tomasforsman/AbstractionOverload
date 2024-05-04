# File Reader App Using Service Locator Pattern

## Introduction

This version of the file reader application is refactored to use the Service Locator pattern. This design pattern provides a central point where objects can register and locate services they require. It simplifies dependency management and enhances modularity.

## Components

### `ServiceLocator`

- **Responsibility**: Acts as a central registry for service instances. It allows registration of services and provides a mechanism to locate them.
- **Implementation**: Contains a dictionary to store services and methods to add services to the registry (`RegisterService`) and retrieve them (`GetService`).

### `IFileReader`

- **Responsibility**: Defines an interface for file reading operations.
- **Implementation**: Implemented by `FileReader` to encapsulate the logic for reading files.

### `FileReader`

- **Responsibility**: Implements the `IFileReader` interface and contains the logic to read content from a file or return a message if the file is not found.

## Advantages

- **Decoupling**: Clients are decoupled from the implementations of the services they use, which promotes loose coupling and greater flexibility.
- **Reusability**: Services registered with the `ServiceLocator` can be reused across different parts of the application.
- **Extensibility**: Adding new services or changing existing ones can be achieved without modifying the clients, as the service configuration is centralized in the `ServiceLocator`.

## Usage

In the application, the `ServiceLocator` is used to register and retrieve an instance of `IFileReader`. The main method retrieves this service to read the content of a file and print it to the console. This pattern is effective for managing dependencies, especially in larger applications or systems with complex object creation and configuration.
