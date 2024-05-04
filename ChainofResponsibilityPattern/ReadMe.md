# File Reader Application with Chain of Responsibility Pattern

## Overview

This application uses the Chain of Responsibility Design Pattern to process file reading requests. This pattern allows a request to pass through a series of handlers until one of them handles the request, thus decoupling the sender of the request from its receivers.

## Components

- **IHandler and AbstractHandler**: Define a common interface for handling requests and an abstract base class that implements default chaining behavior.

- **FileExistenceHandler**: Checks if the file exists and stops the processing chain if the file is not found, otherwise passes the request to the next handler.

- **FileReaderHandler**: Reads and displays the file content. It is capable of passing the request further if needed.

## Usage

The `Program` class constructs the chain of handlers and initiates the request processing. This structure makes it easy to extend the chain with additional handlers for different processing steps without modifying the existing handlers.

## Why Use the Chain of Responsibility Pattern?

This pattern is useful for scenarios where multiple objects can handle a request, but the handler is not known a priori and should be determined automatically. It supports loose coupling and greater flexibility in the distribution of responsibilities among objects.

## How to Run

Compile the C# code with a suitable .NET compiler and run the executable. Ensure the specified file (`example.txt`) is in the same directory as the executable. The output will reflect whether the file was found and its content if available.

