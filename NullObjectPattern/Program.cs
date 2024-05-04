using System;
using System.IO;

interface IFileReader
{
	// Method to read file from path
	void ReadFile(string path);
}

class ConcreteFileReader : IFileReader
{
	public void ReadFile(string path)
	{
		// Reads the file content if file exists
		if (File.Exists(path))
		{
			string content = File.ReadAllText(path);
			Console.WriteLine(content);
		}
		else
		{
			// If file does not exist, delegate the response to a null object
			NullFileReader nullReader = new NullFileReader();
			nullReader.ReadFile(path);
		}
	}
}

class NullFileReader : IFileReader
{
	public void ReadFile(string path)
	{
		// Provides default behavior when the file does not exist
		Console.WriteLine("File not found.");
	}
}

class Program
{
	static void Main(string[] args)
	{
		string filePath = "example.txt";
        
		// Creating a file reader, it will handle the file existence check internally
		IFileReader reader = new ConcreteFileReader();

		// Using reader to read the file
		reader.ReadFile(filePath);
	}
}