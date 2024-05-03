public class FileReaderAdapter : ILogger
{
	private LegacyFileReader _legacyFileReader;
	private string _filePath;

	public FileReaderAdapter(LegacyFileReader legacyFileReader, string filePath)
	{
		_legacyFileReader = legacyFileReader;
		_filePath = filePath;
	}

	public void Log(string message)
	{
		// Using the LegacyFileReader to read the file and log the content indirectly
		string content = _legacyFileReader.ReadFileContent(_filePath);
		Console.WriteLine($"{message}: {content}");
	}
}