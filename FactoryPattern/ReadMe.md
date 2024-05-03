# File Reader with Factory Pattern

This project demonstrates the use of the Factory Pattern to manage the instantiation of objects in a file reading application. The Factory Pattern is essential for encapsulating the creation logic, which allows the application to defer instantiation to subclasses, enhancing flexibility and extensibility.

## Project Structure

The project consists of several key components:

### IFileReader Interface

- **Purpose**: Defines a simple interface with a method `ReadContent()` that must be implemented by any class that reads content. This interface ensures that all file reader types adhere to a common method for reading content.

### TextFileReader Class

- **Purpose**: A concrete implementation of the `IFileReader` interface that reads content from a text file. This class is one example of how a file reader can be implemented.

### FileReaderFactory Class

- **Purpose**: Contains a static method `CreateFileReader` which is responsible for creating file reader objects. This factory class centralizes the creation logic and can be easily extended to accommodate different types of file readers based on various criteria such as file type, size, or other properties.

## Usage

To utilize this application:

1. Make sure there is a file named `example.txt` in the same directory as your executable, or adjust the `filePath` variable in the `Program.cs` main method to match the location of your file.
2. Run the application. The factory will create an appropriate file reader, and if the file exists, its content will be read and displayed; otherwise, you will see a "File not found." message.

## Benefits of Using the Factory Pattern

- **Decoupling**: The application's code does not depend directly on the concrete implementations of file readers. This makes the program more robust and easier to modify or extend.
- **Flexibility**: New file reader types can be added without changing the client code. The factory will handle the instantiation of new reader types as long as they implement the `IFileReader` interface.
- **Simplified Code**: Centralizing the creation logic in a factory simplifies the main application code and concentrates all instantiation logic in one place.

## Extending the Factory

To add more functionality, you can extend the `FileReaderFactory` to:

- Create different file reader types based on the file extension (e.g., `.txt`, `.md`, `.log`).
- Introduce more complex logic to select a reader based on file attributes like size, encoding, or content.

## Conclusion

This project illustrates a practical application of the Factory Pattern in a simple file reading system. By using a factory to manage object creation, the system becomes more modular, maintainable, and ready for future expansions or modifications.
