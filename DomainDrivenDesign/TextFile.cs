class TextFile
{
	public string FilePath { get; private set; }
	public string Content { get; private set; }

	public TextFile(string filePath)
	{
		FilePath = filePath;
	}

	// Domain behavior
	public void LoadContent()
	{
		if (!File.Exists(FilePath))
		{
			throw new FileNotFoundException("File not found.");
		}
		Content = File.ReadAllText(FilePath);
	}

	public void DisplayContent()
	{
		if (Content == null)
		{
			throw new InvalidOperationException("Content has not been loaded.");
		}
		Console.WriteLine(Content);
	}
}