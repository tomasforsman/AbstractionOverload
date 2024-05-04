# File Reader App Using Publish-Subscribe Pattern

## Introduction

This version of the file reader application has been refactored to use the Publish-Subscribe pattern. This design pattern allows components to be loosely coupled and promotes better organization and scalability. The application reads the content from a specified file and prints it to the console or displays a message if the file does not exist.

## Components

### `Publisher`

- **Responsibilities**: Checks if the file exists, reads its content if possible, and publishes the file content or an error message to any subscribers.
- **Events**: Includes a `FileReadHandler` delegate and a `NotifySubscribers` event for broadcasting messages to subscribers.

### `Subscriber`

- **Responsibilities**: Subscribes to the `Publisher` and reacts to its notifications by displaying the message to the console.
- **Connection**: The `Subscriber` attaches its `DisplayMessage` method to the `Publisher`'s `NotifySubscribers` event, reacting to the file read results.

## Advantages

Using the Publish-Subscribe pattern here allows for separation of concerns:
- The `Publisher` component only focuses on file checking and data reading.
- The `Subscriber` component handles data display.
- Additional subscribers could easily be added without modifying the publisher, e.g., to log messages, send notifications, etc.

This pattern is particularly useful in scenarios where the data source triggers multiple actions or responses, enabling flexible and scalable application development.
