# Dependency Injection in File Reader

## Overview
This project demonstrates the implementation of Dependency Injection (DI) in a simple file reading application. DI is a technique to achieve Inversion of Control between classes and their dependencies through dedicated design patterns, improving flexibility and testability.

## Implementation Details
- **IFileReader Interface**: Abstracts file reading operations, allowing for flexible implementation details.
- **FileReader Class**: Concrete implementation of `IFileReader`, responsible for reading file content from the filesystem.
- **ContentDisplay Class**: Utilizes an `IFileReader` to display file content. The `IFileReader` dependency is injected through the constructor.

## Usage
1. Specify the file path in the `Main` method of `Program`.
2. Run the application. The `ContentDisplay` class will use the injected `FileReader` to read and display the file content.

## Benefits of Dependency Injection
- **Decoupling**: Classes are less dependent on specific implementations, leading to a decoupled architecture.
- **Ease of Testing**: Makes unit testing easier by allowing dependencies to be replaced with mocks or stubs.
- **Scalability**: Simplifies adding new functionalities or changing existing implementations without altering dependent classes.

## Conclusion
The use of Dependency Injection in this application simplifies managing dependencies, enhancing the maintainability, testability, and scalability of the software development process.
