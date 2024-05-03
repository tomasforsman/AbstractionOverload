public class TextFileReader : IFileReader
{
	private string _filePath;

	public TextFileReader(string filePath)
	{
		_filePath = filePath;
	}

	public string ReadContent()
	{
		return File.ReadAllText(_filePath);
	}
}