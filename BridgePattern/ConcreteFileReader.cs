public class ConcreteFileReader : IFileReader
{
	public string ReadFile(string path)
	{
		if (File.Exists(path))
		{
			return File.ReadAllText(path);
		}
		else
		{
			return "File not found.";
		}
	}
}