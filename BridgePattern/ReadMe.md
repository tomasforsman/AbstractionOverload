# File Viewer Application

## Introduction

This application demonstrates the use of the Bridge Design Pattern in a simple file viewer application. The Bridge Pattern helps in separating the implementation details of reading a file from the abstraction of displaying its content. This design allows changes to the file reading logic without altering the display logic and vice versa.

## Components

- **IFileReader**: An interface that defines the `ReadFile` method, which is responsible for reading the content from a file.
- **ConcreteFileReader**: A concrete implementation of the `IFileReader` interface that handles the actual file reading operation. It checks if the file exists and reads its content if available.
- **FileViewer**: An abstract class providing an abstraction layer for file viewers. It holds a reference to an `IFileReader`.
- **ConsoleFileViewer**: A refined abstraction that extends `FileViewer` and implements the `Display` method to show file contents on the console.

## Usage

- **Program.cs**: Contains the `Main` method, which is the entry point of the application. It sets up the `ConcreteFileReader` and `ConsoleFileViewer`, then calls the `Display` method to output the file content.

## Benefits of Using the Bridge Pattern

- **Flexibility**: The application can easily be extended to support different types of file readers without changing the client code.
- **Separation of Concerns**: Separates the file handling logic from the display logic, making the codebase easier to manage and evolve.
- **Interchangeability**: Allows the implementation to be switched at runtime, providing dynamic flexibility in the application's behavior.

## Conclusion

The use of the Bridge Pattern in this application allows for a well-organized code structure that is easy to maintain and extend. This pattern is particularly useful in scenarios where both high-level operations and their underlying implementations may vary independently.
