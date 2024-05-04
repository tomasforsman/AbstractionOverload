using System;
using System.IO;

// The FileReader class represents the product being built.

// The FileReaderBuilder class is responsible for constructing the FileReader object.

// Main program class.
class Program
{
	static void Main(string[] args)
	{
		// Use the builder to create and configure a FileReader object.
		FileReader fileReader = new FileReaderBuilder()
			.SetFilePath("example.txt")
			.Build();

		// Attempt to read the file and output the result to the console.
		bool fileReadSuccess = fileReader.ReadFile();
		Console.WriteLine(fileReader.Content);
	}
}