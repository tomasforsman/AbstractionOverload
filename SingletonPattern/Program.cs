using System;
using System.IO;

class Program
{
	static void Main(string[] args)
	{
		string filePath = "example.txt";
        
		// Using the Singleton to read the file
		string content = SingletonFileReader.Instance.ReadFile(filePath);
		Console.WriteLine(content);
	}
}