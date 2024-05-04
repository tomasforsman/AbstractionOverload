class FileOriginator
{
	private string content;

	public void SetContent(string filePath)
	{
		if (File.Exists(filePath))
		{
			this.content = File.ReadAllText(filePath);
		}
		else
		{
			this.content = null;  // Represents no content (file not found).
		}
	}

	public FileMemento Save()
	{
		return new FileMemento(this.content);
	}

	public void Restore(FileMemento memento)
	{
		this.content = memento.Content;
	}

	public void Display()
	{
		if (this.content != null)
		{
			Console.WriteLine(this.content);
		}
		else
		{
			Console.WriteLine("File not found.");
		}
	}
}