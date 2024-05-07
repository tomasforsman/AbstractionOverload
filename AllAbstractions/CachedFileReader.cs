public class CachedFileReader : IFileReader
{
	private readonly IFileReader _wrappedReader;
	private string _cachedContent;
	private DateTime _lastReadTime;

	public CachedFileReader(IFileReader reader)
	{
		_wrappedReader = reader;
		_cachedContent = string.Empty;
		_lastReadTime = DateTime.MinValue;
	}

	public string ReadFile(string path)
	{
		if ((DateTime.Now - _lastReadTime).TotalMinutes > 5)
		{
			_cachedContent = _wrappedReader.ReadFile(path);
			_lastReadTime = DateTime.Now;
		}
		return _cachedContent;
	}
}