using System;
using System.IO;

class Program
{
	static void Main(string[] args)
	{
		string filePath = "example.txt";

		// Use the factory to create the appropriate file reader
		IFileReader fileReader = FileReaderFactory.CreateFileReader(filePath);

		if (File.Exists(filePath))
		{
			string content = fileReader.ReadContent();
			Console.WriteLine(content);
		}
		else
		{
			Console.WriteLine("File not found.");
		}
	}
}