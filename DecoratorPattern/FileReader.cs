public class FileReader : IContentReader
{
	private string _filePath;

	public FileReader(string filePath)
	{
		_filePath = filePath;
	}

	public string ReadContent()
	{
		return File.ReadAllText(_filePath);
	}
}