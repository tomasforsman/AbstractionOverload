using System;
using System.IO;

// Abstract class with a template method

// Concrete class

// Client
class Program
{
	static void Main(string[] args)
	{
		string filePath = "example.txt";
		FileProcessor fileProcessor = new DisplayFileProcessor();
		fileProcessor.ProcessFile(filePath);
	}
}