public class FileReadEvent : IFileEvent
{
	public string FilePath { get; private set; }

	public FileReadEvent(string filePath)
	{
		FilePath = filePath;
	}

	public void Process()
	{
		if (!File.Exists(FilePath))
		{
			Console.WriteLine("File not found.");
			return;
		}
		var content = File.ReadAllText(FilePath);
		Console.WriteLine($"File read: {content}");
	}
}