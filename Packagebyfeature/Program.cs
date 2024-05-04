using System;

	class Program
	{
		static void Main(string[] args)
		{
			string filePath = "example.txt";
			IFileReader reader = new ConcreteFileReader();
			reader.ReadFile(filePath);
			filePath = "nonexistingfile.txt";
			reader.ReadFile(filePath);
		}
	}