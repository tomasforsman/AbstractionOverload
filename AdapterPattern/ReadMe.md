# Adapter Pattern File Reader

## Overview
This project demonstrates the implementation of the Adapter design pattern in a file reading application. The Adapter pattern allows the integration of classes with incompatible interfaces, enabling them to work together seamlessly.

## Implementation Details
- **LegacyFileReader**: An existing class that provides functionality to read file content. It outputs the content as a string.
- **ILogger Interface**: Represents the new system's requirement for logging messages.
- **FileReaderAdapter**: An adapter class that implements `ILogger` and uses a `LegacyFileReader` to read and log file content according to the new system's expectations.

## Usage
To use this application:
1. Ensure a file named `example.txt` exists in your project's directory or modify the `filePath` in the `Program` class accordingly.
2. Run the application. The `FileReaderAdapter` will use the `LegacyFileReader` to read the file and then log the content through the console, simulating the new logger's functionality.

## Advantages of the Adapter Pattern
- **Compatibility**: Allows classes with incompatible interfaces to work together.
- **Reusability**: Enables existing classes to be reused without modifying their source code.
- **Flexibility**: Adapters can be created to match the expected interfaces of different systems without changing the business logic.

## Conclusion
The Adapter pattern in this application bridges the gap between an old file reading system and a new logging system, demonstrating how legacy systems can be adapted to meet new interface requirements without direct modifications.
