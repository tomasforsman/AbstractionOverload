namespace FileReadingApp;

public class FileReader : IFileReader
{
	public string ReadFileContent(string filePath)
	{
		if (File.Exists(filePath))
		{
			return File.ReadAllText(filePath);
		}
		return null;
	}
}