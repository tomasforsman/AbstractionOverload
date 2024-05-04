class Program
{
	static async Task Main(string[] args)
	{
		string filePath = "example.txt";
		try
		{
			string content = await ReadFileContentAsync(filePath);
			Console.WriteLine(content);
		}
		catch (FileNotFoundException)
		{
			Console.WriteLine("File not found.");
		}
	}

	static async Task<string> ReadFileContentAsync(string filePath)
	{
		if (File.Exists(filePath))
		{
			using (var reader = File.OpenText(filePath))
			{
				return await reader.ReadToEndAsync();
			}
		}
		throw new FileNotFoundException();
	}
}