class Program
{
	static void Main(string[] args)
	{
		string filePath = "example.txt";
            
		if (File.Exists(filePath))
		{
			Console.WriteLine("Reading file in normal order:");
			var fileLines = new FileLines(filePath, reverse: false);
			foreach (var line in fileLines)
			{
				Console.WriteLine(line);
			}

			Console.WriteLine("\nReading file in reverse order:");
			fileLines = new FileLines(filePath, reverse: true);
			foreach (var line in fileLines)
			{
				Console.WriteLine(line);
			}
		}
		else
		{
			Console.WriteLine("File not found.");
		}
	}
}