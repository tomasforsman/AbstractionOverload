# Observer Pattern File Reader

## Overview
This project demonstrates the implementation of the Observer design pattern within a file reading application. The Observer pattern allows objects to notify other objects about changes without making them tightly coupled.

## Implementation Details
- **ISubject Interface**: Provides methods for attaching and detaching observers, and for notifying them of any messages.
- **IObserver Interface**: Defines the `Update` method that observers must implement to receive notifications.
- **FileReader**: A subject that notifies observers about the file's content after reading it. If the file does not exist, it sends a "File not found." message.
- **ConsoleLogger**: An observer that outputs notifications to the console, demonstrating how an observer might react to an update.

## Usage
To read a file and observe notifications:
1. Modify the `filePath` in the `Main` method to point to your target file.
2. Run the application. The `FileReader` subject reads the file and notifies all attached observers about the content or lack thereof.

## Advantages of the Observer Pattern
- **Decoupling**: Observers are loosely coupled to the subject, meaning the subject knows very little about the observers, other than that they implement the `IObserver` interface.
- **Dynamic Relationships**: New observers can be added or removed dynamically at runtime without affecting the subject.
- **Broadcast Communication**: Changes in the subject are broadcast to all interested observers, making the pattern ideal for scenarios where changes to one object may affect many others.

## Conclusion
This implementation showcases the Observer pattern applied to a simple file reading operation, providing a clear example of how changes in one part of a system can be automatically and efficiently propagated to other parts of the system without tight coupling.
