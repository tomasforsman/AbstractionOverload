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

	public async Task<string> ReadFileAsync(string path)
	{
		if ((DateTime.Now - _lastReadTime).TotalMinutes > 5)
		{
			_cachedContent = await _wrappedReader.ReadFileAsync(path);
			_lastReadTime = DateTime.Now;
		}
		return _cachedContent;
	}
}