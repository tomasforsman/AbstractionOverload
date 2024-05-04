public class FileOpenedEvent : IFileEvent
{
	public string FilePath { get; private set; }

	public FileOpenedEvent(string filePath)
	{
		FilePath = filePath;
	}

	public void Process()
	{
		Console.WriteLine($"File opened: {FilePath}");
	}
}