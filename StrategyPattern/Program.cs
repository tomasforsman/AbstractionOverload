using System;
using System.IO;

class Program
{
	static void Main(string[] args)
	{
		string filePath = "example.txt";

		// Use the UpperCaseProcessor strategy
		IContentProcessor upperCaseProcessor = new UpperCaseProcessor();
		ContentReader reader = new ContentReader(upperCaseProcessor);
		reader.ReadAndProcessContent(filePath);

		Console.WriteLine("\n-----------------------\n"); // Adds a separator between outputs

		// Switch to the PlainTextProcessor strategy
		IContentProcessor plainTextProcessor = new PlainTextProcessor();
		reader = new ContentReader(plainTextProcessor);
		reader.ReadAndProcessContent(filePath);
	}
}