using Serilog;

public class BasicFileReader : IFileReader
{
	public async Task<string> ReadFileAsync(string path)
	{
		try
		{
			return await File.ReadAllTextAsync(path);
		}
		catch (Exception ex)
		{
			Log.Error(ex, "Error reading file at {Path}", path);
			throw;
		}
	}
}