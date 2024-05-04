using Metalama.Framework;

// Apply the LoggingAspect to all methods of this class.
public class FileReader
{
	private readonly string _filePath;

	public FileReader(string filePath)
	{
		_filePath = filePath;
	} 
	[Log]
	[HandleError]
	public void ReadFile()
	{
		if (!File.Exists(_filePath))
		{
			throw new FileNotFoundException($"The file '{_filePath}' does not exist.");
		}

		var content = File.ReadAllText(_filePath);
		Console.WriteLine(content);
	}
}