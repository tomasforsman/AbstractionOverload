public class FileReader
{
	private string filePath;

	public FileReader(string filePath)
	{
		this.filePath = filePath;
	}

	[LoggingAspect]
	[HandleErrorAspect]
	public void ReadFile()
	{
		if (!File.Exists(filePath))
		{
			throw new FileNotFoundException("File does not exist.");
		}
        
		string content = File.ReadAllText(filePath);
		Console.WriteLine(content);
	}
}