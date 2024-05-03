public class ContentDisplay
{
	private IFileReader _fileReader;

	// Constructor injection
	public ContentDisplay(IFileReader fileReader)
	{
		_fileReader = fileReader;
	}

	public void Display(string filePath)
	{
		var content = _fileReader.ReadFile(filePath);
		Console.WriteLine(content);
	}
}