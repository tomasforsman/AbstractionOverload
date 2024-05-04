# FileReader Project using Abstract Factory Pattern

This project demonstrates the implementation of the Abstract Factory pattern in a simple C# application designed to read files using either synchronous or asynchronous methods based on runtime decisions.

## Implementation Details

### Core Components

1. **IFileReader Interface**
    - Defines the `ReadFile` method that all concrete file reader products will implement.

2. **Concrete Products**
    - `SyncFileReader`: Reads files synchronously.
    - `AsyncFileReader`: Reads files asynchronously.

3. **IReaderFactory Interface**
    - An interface for creating objects in the FileReader family.

4. **Concrete Factories**
    - `SyncReaderFactory`: Creates instances of `SyncFileReader`.
    - `AsyncReaderFactory`: Creates instances of `AsyncFileReader`.

### Abstract Factory Pattern Usage

- **Interface-Driven Design**: Factories and products are based on interfaces, ensuring that the implementations can vary independently of client code.
- **Support for Families of Products**: The pattern supports creating families of related products without specifying their concrete classes.
- **Runtime Flexibility**: Allows the application to decide at runtime which type of file reading method to use based on external input or configuration.

## Usage

Run the `Program.cs` with an optional command line argument:
- Pass `"async"` to use asynchronous file reading.
- Pass nothing or any other string to use synchronous file reading.

## Conclusion

The Abstract Factory pattern enables the application to defer instantiation of concrete classes to runtime based on the environment and configuration. This leads to greater flexibility and adherence to the Open/Closed principle, making the application easier to extend and maintain.
