using System;
using System.IO;

// Aspect for logging

// Aspect for handling errors

// Main file reader class with aspects applied

// Main program class
class Program
{
	static void Main(string[] args)
	{
		FileReader reader = new FileReader("example.txt");
		reader.ReadFile();
	}
}