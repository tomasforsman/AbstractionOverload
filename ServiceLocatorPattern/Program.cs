using System;
using System.IO;

class Program
{
	static void Main(string[] args)
	{
		string filePath = "example.txt";
		ServiceLocator.RegisterService<IFileReader>(new FileReader());

		var fileReader = ServiceLocator.GetService<IFileReader>();
		Console.WriteLine(fileReader.ReadFile(filePath));
	}
}