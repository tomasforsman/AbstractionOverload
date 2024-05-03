// Implement the interface with a concrete class
public class TextFileReader : IFileReader
{
	// Method to read the contents of a file
	public string ReadFile(string path)
	{
		return File.ReadAllText(path);
	}
}