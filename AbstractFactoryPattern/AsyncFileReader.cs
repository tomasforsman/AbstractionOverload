public class AsyncFileReader : IFileReader
{
	private string filePath;

	public AsyncFileReader(string filePath)
	{
		this.filePath = filePath;
	}

	public async Task<string> ReadFileAsync()
	{
		if (File.Exists(filePath))
		{
			return await File.ReadAllTextAsync(filePath);
		}
		else
		{
			return "File not found.";
		}
	}

	string IFileReader.ReadFile()
	{
		return ReadFileAsync().Result;
	}
}