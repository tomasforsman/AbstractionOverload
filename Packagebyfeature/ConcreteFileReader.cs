public class ConcreteFileReader : IFileReader
{
	public void ReadFile(string path)
	{
		if (File.Exists(path))
		{
			string content = File.ReadAllText(path);
			Console.WriteLine(content);
		}
		else
		{
			NullFileReader nullReader = new NullFileReader();
			nullReader.ReadFile(path);
		}
	}
}