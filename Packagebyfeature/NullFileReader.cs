public class NullFileReader : IFileReader
{
	public void ReadFile(string path)
	{
		Console.WriteLine("File not found.");
	}
}