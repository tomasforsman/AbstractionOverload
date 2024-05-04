class FileMemento
{
	public string Content { get; private set; }
    
	public FileMemento(string content)
	{
		Content = content;
	}
}