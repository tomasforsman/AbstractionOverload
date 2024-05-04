# FileReader Project using Builder Pattern

This project demonstrates the implementation of the Builder pattern in a simple C# application that reads the contents of a file and displays them. The Builder pattern is utilized here to separate the construction of a complex object (`FileReader`) from its representation. This allows the same construction process to create different representations.

## Implementation Details

### Classes and Their Roles

1. **FileReader**
    - This is the "product" class, which represents the complex object being built.
    - Properties:
        - `FilePath`: The path to the file that needs to be read.
        - `Content`: The content read from the file.
    - Methods:
        - `ReadFile()`: Checks if the file exists at `FilePath` and reads its content into `Content`. Returns `true` if the file is read successfully, otherwise `false`.

2. **FileReaderBuilder**
    - This is the "builder" class, responsible for creating an instance of `FileReader`.
    - Methods:
        - `SetFilePath(string filePath)`: Sets the file path for the `FileReader`. Returns the builder object for chaining.
        - `Build()`: Finalizes the construction of the `FileReader` and returns the built object.

3. **Program**
    - This class contains the `Main` method, the entry point of the application.
    - It uses `FileReaderBuilder` to create a `FileReader` instance, sets the file path, and reads the file.

### Builder Pattern Usage

- **Separation of Construction and Representation**: The `FileReaderBuilder` takes care of constructing the `FileReader` instance. This separation allows for more complex configurations of the `FileReader` without cluttering the client code.
- **Step-by-step Construction**: The builder allows the file reader's properties to be set in steps which is useful for validating state before object completion.
- **Flexibility in Object Creation**: More methods can be easily added to `FileReaderBuilder` to support various configurations of `FileReader`, enhancing flexibility and reusability.

## Usage

To use this application, simply run the `Program.cs`. The main method initializes a `FileReader` through its builder, attempts to read the content from a specified file path, and prints the content or an error message to the console.

## Conclusion

The Builder pattern helps in creating complex objects while keeping the construction process separate from the components themselves, promoting scalability and maintainability. This project provides a basic example of how to implement and utilize the Builder pattern in C# applications.

