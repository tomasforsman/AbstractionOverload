using System;
using System.IO;

class Program
{
	static void Main(string[] args)
	{
		string filePath = "example.txt";
		FileExistsSpecification fileExistsSpec = new FileExistsSpecification();
        
		if (fileExistsSpec.IsSatisfiedBy(filePath))
		{
			string content = File.ReadAllText(filePath);
			Console.WriteLine(content);
		}
		else
		{
			Console.WriteLine("File not found.");
		}
	}
}

class FileExistsSpecification
{
	public bool IsSatisfiedBy(string filePath)
	{
		return File.Exists(filePath);
	}
}