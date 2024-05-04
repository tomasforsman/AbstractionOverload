class FileNotExistsState : IFileState
{
	public void Handle(FileContext context)
	{
		Console.WriteLine("File not found.");
	}
}