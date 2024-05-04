public class FileReader : IFileReader
{
	public string ReadFile(string path)
	{
		if (File.Exists(path))
		{
			return File.ReadAllText(path);
		}
		return "File not found.";
	}
}