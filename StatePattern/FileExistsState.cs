class FileExistsState : IFileState
{
	private string content;

	public FileExistsState(string filePath)
	{
		content = File.ReadAllText(filePath);
	}

	public void Handle(FileContext context)
	{
		Console.WriteLine(content);
	}
}