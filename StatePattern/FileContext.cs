class FileContext
{
	public IFileState State { get; set; }

	public FileContext(string filePath)
	{
		State = File.Exists(filePath) ? (IFileState)new FileExistsState(filePath) : new FileNotExistsState();
	}

	public void Display()
	{
		State.Handle(this);
	}
}