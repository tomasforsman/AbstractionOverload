using System;
using System.IO;

class Program
{
	static void Main(string[] args)
	{
		string filePath = "example.txt";

		if (File.Exists(filePath))
		{
			// Create the basic FileReader wrapped with a LoggingReader
			IContentReader reader = new LoggingReader(new FileReader(filePath));
			string content = reader.ReadContent();
			Console.WriteLine(content);
		}
		else
		{
			Console.WriteLine("File not found.");
		}
	}
}