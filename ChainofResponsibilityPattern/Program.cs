using System;
using System.IO;

// Handler Interface

// Abstract Handler

// Concrete Handler for File Existence Check

// Concrete Handler for Reading File Content

// Client
class Program
{
	static void Main(string[] args)
	{
		string filePath = "example.txt";

		// Building the chain
		IHandler fileExistence = new FileExistenceHandler();
		IHandler fileReader = new FileReaderHandler();

		fileExistence.SetNext(fileReader);

		// Starting the chain
		fileExistence.Handle(filePath);
	}
}