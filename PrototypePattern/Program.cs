using System;
using System.IO;

class Program
{
	static void Main(string[] args)
	{
		string filePath = "example.txt";

		// Creating a file reader and cloning it
		IFileReaderPrototype original = new ConcreteFileReader();
		IFileReaderPrototype clonedReader = original.Clone();

		// Using cloned reader to read the file
		clonedReader.ReadFile(filePath);
	}
}