using System;
using System.IO;

// Element interface declares an `Accept` method that takes the base visitor interface as an argument.

// Concrete Elements implement various types of files.

// The Visitor interface.

// A Concrete Visitor implements operations defined by the visitor interface.

// Main application
class Program
{
	static void Main(string[] args)
	{
		IFileElement file = new TextFile("example.txt");
		IFileVisitor visitor = new FileReaderVisitor();
		file.Accept(visitor);
	}
}