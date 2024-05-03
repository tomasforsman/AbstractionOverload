namespace BaseApp;

// Define a class named 'Program'. This is typically the entry class for a C# application.
class Program
{
	// The 'Main' method is the entry point of any C# console application.
	// The 'args' parameter represents any command-line arguments passed to the application.
	static void Main(string[] args)
	{
		// Declare a string variable 'filePath' and initialize it with the value "example.txt".
		// This specifies the name of the file you want to read.
		string filePath = "example.txt";
        
		// Check if the file specified by 'filePath' exists in the current working directory.
		if (File.Exists(filePath))
		{
			// If the file exists, read all the text from the file into the variable 'content'.
			string content = File.ReadAllText(filePath);
            
			// Output the contents of the file to the console.
			Console.WriteLine(content);
		}
		else
		{
			// If the file does not exist, output "File not found." to the console.
			Console.WriteLine("File not found.");
		}
	}
}
