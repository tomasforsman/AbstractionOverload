# Async File Reader Using Event-Based Asynchronous Pattern

## Overview

This application demonstrates the use of the Event-Based Asynchronous Pattern (EAP) to perform non-blocking file operations in .NET. This pattern involves using events to handle the completion of asynchronous tasks.

## Components

- **FileReader**: Manages asynchronous file reading using a `BackgroundWorker`. It exposes a `FileReadCompleted` event to notify when the reading is completed.

- **BackgroundWorker**: Handles the execution of the file reading operation in the background, raising events upon completion.

- **FileReadEventArgs**: Custom event args class containing data related to the file read operation such as file content, errors, and cancellation status.

## Usage

The application sets up the `FileReader`, subscribes to the `FileReadCompleted` event, and invokes the asynchronous read operation. The main thread remains responsive, waiting for user input to terminate, while file reading proceeds in the background.

## Why Use EAP?

EAP provides a structured way to handle asynchronous operations using events, making it easier to manage long-running tasks without blocking the main application thread. It is especially useful in GUI applications where maintaining responsiveness is crucial.

## How to Run

Compile the C# code with a suitable .NET compiler
