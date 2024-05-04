namespace FileReadingApp
{
	// Presentation Layer
	class Program
	{
		static void Main(string[] args)
		{
			string filePath = "example.txt";
			var fileService = new FileService();
			string content = fileService.ReadFile(filePath);
			Console.WriteLine(content ?? "File not found.");
		}
	}

}