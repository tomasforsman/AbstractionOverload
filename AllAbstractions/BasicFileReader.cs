public class BasicFileReader : IFileReader
{
	public string ReadFile(string path)
	{
		return File.ReadAllText(path);
	}
}