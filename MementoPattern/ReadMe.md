# File Reader Application with Memento Pattern

## Overview

This application demonstrates the use of the Memento Design Pattern to manage the state of a file's content. The Memento Pattern allows the application to save and restore the state of an object without exposing its internal details.

## Components

- **FileMemento**: Holds the state of the file's content. This state can be saved and restored as needed without direct interaction with the file system.

- **FileOriginator**: Responsible for generating and using mementos. It can read a file's content, create a snapshot of its state, and restore to a previous state using a memento.

- **Caretaker**: Stores the memento. It acts as the state manager but does not modify or directly interact with the state stored in the memento.

## Usage

The `Program` class orchestrates the creation and management of file content states. It initializes an originator to load a file's content, saves the state via a caretaker, and can restore the state from the caretaker when required.

## Why Use the Memento Pattern?

The Memento Pattern is typically used for implementing undo capabilities in applications. In this application, it is adapted to manage file states, allowing the application to revert to previous versions of file contents or handle changes in a controlled manner.

## How to Run

Compile the C# code with a suitable compiler and run the executable. The application will attempt to read the content of `example.txt`, save its state, and display it. Changes to the state can be managed and reverted using the memento managed by the caretaker.

