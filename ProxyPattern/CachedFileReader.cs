public class CachedFileReader : IFileReader
{
	private RealFileReader _realFileReader;
	private string _cachedContent;
	private string _cachedFilePath;

	public CachedFileReader(RealFileReader realFileReader)
	{
		_realFileReader = realFileReader;
	}

	public string ReadFile(string filePath)
	{
		// Check if the file path matches the cached file path and if the cache is not empty
		if (_cachedFilePath == filePath && _cachedContent != null)
		{
			Console.WriteLine("Returning cached content.");
			return _cachedContent;
		}
		else
		{
			Console.WriteLine("Reading from disk.");
			_cachedContent = _realFileReader.ReadFile(filePath);
			_cachedFilePath = filePath;
			return _cachedContent;
		}
	}
}