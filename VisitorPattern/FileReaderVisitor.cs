public class FileReaderVisitor : IFileVisitor
{
	public void Visit(TextFile file)
	{
		if (File.Exists(file.FilePath))
		{
			Console.WriteLine($"Reading File: {file.FilePath}");
			string content = File.ReadAllText(file.FilePath);
			Console.WriteLine(content);
		}
		else
		{
			Console.WriteLine("File not found.");
		}
	}
}