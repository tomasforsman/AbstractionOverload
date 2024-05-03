# Singleton Pattern File Reader

## Overview
This project implements the Singleton design pattern to manage a file reading operation. The Singleton pattern ensures that a class has only one instance and provides a global point of access to it.

## Implementation Details
- **SingletonFileReader**: A class that encapsulates file reading functionality and is implemented as a Singleton.
    - The class prevents external instantiation and modification by having a private constructor and a private static instance variable.
    - It provides a thread-safe mechanism to access the single instance via a static property that uses double-checked locking.
    - The `ReadFile` method reads the contents of a file if it exists, returning the content or a message indicating the file is not found.

## Usage
To read a file using this application:
1. Ensure a file named `example.txt` exists in the directory from where the application is executed or modify the `filePath` in the `Main` method.
2. Run the application. It will use the Singleton instance of `SingletonFileReader` to perform the file read operation.

## Advantages of Singleton Pattern
- **Resource Management**: Ensures that only a single instance of the file reader is created, which can be useful when the reader maintains a cache or shared configuration settings.
- **Consistency**: Provides a consistent point of access for all clients needing to read files, which is helpful in a multi-threaded environment.

## Conclusion
This implementation of the Singleton pattern provides a robust, thread-safe mechanism for managing file reading operations with a single, shared instance, thus ensuring efficient use of resources and consistent behavior across the application.
