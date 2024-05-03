using System;
using System.IO;

class Program
{
	static void Main(string[] args)
	{
		string filePath = "example.txt";

		// Create a command object for reading a file
		ICommand readFileCommand = new ReadFileCommand(filePath);

		// Create an invoker object and execute the command
		FileOperationExecutor executor = new FileOperationExecutor(readFileCommand);
		executor.PerformOperation();
	}
}