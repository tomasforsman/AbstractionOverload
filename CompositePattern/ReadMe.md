# File Reader Application with Composite Pattern

## Overview

This application demonstrates the use of the Composite Design Pattern in a simple file reader application. The Composite Pattern allows you to compose objects into tree structures to represent part-whole hierarchies. This makes it easier to add new types of operations on files without changing the existing code structure.

## Components

- **FileComponent**: An abstract base class that defines the `Display` method. All components in this pattern must implement this method.

- **FileReader**: A concrete implementation of `FileComponent` that reads content from a specified file path. If the file does not exist, it delegates the responsibility to display an error message to the `FileNotFound` component.

- **FileNotFound**: Another concrete implementation of `FileComponent`, used solely to display an error message when a file is not found.

## Usage

The main class `Program` initializes a `FileReader` with a specified file path and calls `Display` on it. Depending on the existence of the file, it either displays the file contents or an error message.

## Why Use the Composite Pattern?

The use of the Composite Pattern in this application allows for flexible handling of file operations. Components can be added or modified independently, adhering to the Open/Closed Principle. It simplifies the client code and makes the system more adaptable to future requirements, such as adding different types of file operations or handling other kinds of errors.

## How to Run

To run this application, compile the code with a C# compiler and execute the resulting binary with a valid file path. Ensure that the `example.txt` file exists in the application's directory to see the content display functionality.

