# File Reader Application with Layered Architecture

## Overview

This application demonstrates the use of a Layered Architecture to separate concerns among presentation, business logic, and data access layers. This structure enhances maintainability and scalability by organizing code into distinct responsibilities.

## Components

- **Presentation Layer**: Manages user interaction, displaying results or errors to the user.

- **Business Logic Layer**: Implements the core functionality and rules of the application. In this case, it manages file reading operations.

- **Data Access Layer**: Handles all data storage and retrieval operations. Here, it encapsulates the logic for accessing file data.

## Usage

The application reads content from a specified file and displays it. If the file does not exist, it informs the user that the file was not found. This separation ensures that changes in one layer (like changing the data access strategy) do not affect other layers.

## Why Use Layered Architecture?

Layered Architecture simplifies development and maintenance by separating concerns. Each layer can be developed and tested independently, reducing dependencies across the application.

## How to Run

Compile the C# code with a suitable .NET compiler and run the executable. Ensure the specified file (`example.txt`) is in the same directory as the executable or update the file path accordingly.

