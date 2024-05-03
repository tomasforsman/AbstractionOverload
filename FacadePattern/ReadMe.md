# Facade Pattern in File Reading Application

## Overview
This project demonstrates the use of the Facade Pattern in a simple file reading application. The Facade Pattern provides a simplified interface to more complex subsystems, enhancing ease of use and reducing client-side complexity.

## Implementation Details
- **FileReader**: Manages reading files from the disk.
- **ContentDisplayer**: Handles the output of file content to the console.
- **FileOperationsFacade**: Offers a high-level interface (`ReadAndDisplayFile`) that utilizes `FileReader` and `ContentDisplayer` to read and display file content seamlessly.

## Usage
1. Specify the `filePath` in the `Main` method of the `Program`.
2. Run the application to use the facade to read and display file content.

## Benefits of Facade Pattern
- **Ease of Use**: Clients use a single, straightforward interface to interact with the underlying subsystems.
- **Isolation**: Clients are isolated from the complexities of the subsystems.
- **Flexibility**: The implementation of the subsystem can change without affecting its clients.

## Conclusion
The Facade Pattern effectively reduces complexity and improves usability in software applications by providing a simple interface to complex subsystems, as demonstrated in this file reading application.
