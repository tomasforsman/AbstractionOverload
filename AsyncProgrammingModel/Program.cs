using System;
using System.IO;
using System.Threading.Tasks;

class Program
{
	static async Task Main(string[] args)
	{
		string filePath = "example.txt";
		try
		{
			string content = await ReadFileAsync(filePath);
			Console.WriteLine(content);
		}
		catch (FileNotFoundException)
		{
			Console.WriteLine("File not found.");
		}
		catch (Exception ex)
		{
			Console.WriteLine($"An error occurred: {ex.Message}");
		}
	}

	static async Task<string> ReadFileAsync(string filePath)
	{
		if (!File.Exists(filePath))
		{
			throw new FileNotFoundException();
		}

		using (var reader = File.OpenText(filePath))
		{
			return await reader.ReadToEndAsync();
		}
	}
}