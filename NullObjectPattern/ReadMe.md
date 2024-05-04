# Simple File Reader Application

This application demonstrates the use of the Null Object Pattern in a simple C# file reader. The Null Object Pattern helps in avoiding null reference checks throughout the code by providing an object that implements a default behavior.

## Implementation Details

- **IFileReader Interface**: This interface defines a method for reading files. It is implemented by any class that reads files, including our null object.

- **ConcreteFileReader Class**: Implements the `IFileReader` and reads files if they exist. It delegates to a null object if the file does not exist.

- **NullFileReader Class**: This class also implements the `IFileReader` interface but provides a default behavior for the scenario where the file does not exist. This helps in avoiding checks for `null` and handling of exceptions elsewhere in the code.

- **Program Class**: The main entry point for the application. It initializes a `ConcreteFileReader` and uses it to read a file.

## How It Works

1. An instance of `ConcreteFileReader` is created and asked to read a file.
2. If the file exists, `ConcreteFileReader` reads and displays the content.
3. If the file does not exist, `ConcreteFileReader` creates an instance of `NullFileReader`, which then handles the response by printing a predefined message.

By using the Null Object Pattern, this application simplifies error handling and improves the robustness of the file reading process.
