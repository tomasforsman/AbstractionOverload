class Program
{
	static void Main(string[] args)
	{
		string filePath = "example.txt";
        
		// Create an instance of the TextFileReader using the IFileReader interface
		IFileReader fileReader = new TextFileReader();
        
		// Check if the file exists
		if (File.Exists(filePath))
		{
			// Use the ReadFile method from the interface to read the file
			string content = fileReader.ReadFile(filePath);
			Console.WriteLine(content);
		}
		else
		{
			Console.WriteLine("File not found.");
		}
	}
}