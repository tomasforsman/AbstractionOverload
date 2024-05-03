public class LegacyFileReader
{
	public string ReadFileContent(string filePath)
	{
		if (File.Exists(filePath))
		{
			return File.ReadAllText(filePath);
		}
		else
		{
			return "File not found.";
		}
	}
}