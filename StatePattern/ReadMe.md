# File Reader Application with State Pattern

## Overview

This application demonstrates the use of the State Design Pattern to handle different file states in a file reading application. By encapsulating state-dependent behaviors into separate classes, the application changes its behavior dynamically based on the file's existence.

## Components

- **IFileState**: An interface that defines a method for handling file-based behaviors.

- **FileExistsState**: A concrete state that handles behavior when a file exists, specifically reading and displaying the file's content.

- **FileNotExistsState**: A concrete state that handles behavior when a file does not exist, specifically displaying an error message.

- **FileContext**: The context class maintains a reference to the current state of the file and delegates the state-specific behavior to its state object.

## Usage

The `Program` class, acting as the client, creates a `FileContext` instance with a specified file path. The `FileContext` checks the file's existence and sets its state accordingly. It then delegates the behavior to the current state object through the `Display` method.

## Why Use the State Pattern?

The State Pattern simplifies the management of state-dependent behavior by localizing state-specific behaviors in their respective classes. This not only makes the application easier to extend (e.g., adding new states or behaviors) but also keeps the code cleaner and more modular.

## How to Run

Compile the C# code with a suitable compiler and run the executable. The behavior of the application will change dynamically based on whether the specified file (`example.txt`) exists.

