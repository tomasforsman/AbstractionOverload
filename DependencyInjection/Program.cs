using System;
using System.IO;

class Program
{
	static void Main(string[] args)
	{
		string filePath = "example.txt";
		IFileReader fileReader = new FileReader(); // FileReader dependency is created here
		ContentDisplay display = new ContentDisplay(fileReader); // Dependency injected

		display.Display(filePath);
	}
}