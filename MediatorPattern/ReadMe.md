# File Reader Application Using Mediator Pattern

## Overview

This application implements the Mediator Pattern to decouple the file reading logic from the display logic. By using a mediator, the application components communicate indirectly through a central point, which simplifies the dependencies between them.

## Components

- **IMediator**: Interface that defines the method for sending notifications.
- **FileOperationsMediator**: Concrete mediator that handles the coordination between FileReader and DisplayHandler.
- **FileReader & DisplayHandler**: Components that perform specific tasks and communicate via the mediator.

## Usage

This approach encapsulates how components interact and makes it easier to manage the application's flow and logic, reducing direct dependencies among components.

## Why Use the Mediator Pattern?

The Mediator Pattern simplifies object communication and control mechanisms, making them easier to customize and maintain. It is particularly useful for applications where component interactions are complex.

## How to Run

Compile the C# code with a suitable .NET compiler and run the executable. Ensure the specified file (`example.txt`) is in the same directory as the executable.

