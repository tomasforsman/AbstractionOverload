public class LoggingFileReaderProxy : IFileReader
{
	private IFileReader _realFileReader;

	public LoggingFileReaderProxy(IFileReader realFileReader)
	{
		_realFileReader = realFileReader;
	}

	public string ReadFile(string path)
	{
		// Log before accessing the file
		Console.WriteLine($"Reading file: {path}");
        
		string content = _realFileReader.ReadFile(path);
        
		// Log after file is read
		Console.WriteLine($"Finished reading file: {path}");
        
		return content;
	}
}