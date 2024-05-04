# File Reader App Using Specification Pattern

## Introduction

This version of the file reader application is refactored using the Specification Pattern. This pattern is particularly useful for encapsulating business rules that determine whether certain conditions are met. In this application, it checks if a file exists.

## Components

### `FileExistsSpecification`

- **Responsibility**: Encapsulates the rule that checks if a given file exists in the specified path.
- **Method**: `IsSatisfiedBy(string filePath)`: Returns `true` if the file exists, otherwise `false`.

## Advantages

Using the Specification Pattern provides the following benefits:

- **Reusability**: The file existence check can be reused in multiple parts of an application without rewriting the checking logic.
- **Decoupling**: Business rules (specifications) are decoupled from the other parts of the application. This separation improves the maintainability and clarity of the application.
- **Extensibility**: More specifications (like file size, file type, etc.) can easily be added and combined using logical operations without changing the existing specifications.

## Use Case

In this application, the specification is used directly in the main method to decide whether to read the file content or output a not-found message. This approach maintains a clear separation between the rule (file existence) and the actions taken based on this rule.
