using System;
using System.IO;
using System.Collections.Generic;

class Program
{
	static void Main(string[] args)
	{
		string filePath = "example.txt";

		FileReader fileReader = new FileReader(filePath);
		ConsoleLogger consoleLogger = new ConsoleLogger();

		// Attaching the observer
		fileReader.Attach(consoleLogger);

		// Perform the read operation which triggers notifications
		fileReader.ReadFile();

		// Detaching the observer
		fileReader.Detach(consoleLogger);
	}
}