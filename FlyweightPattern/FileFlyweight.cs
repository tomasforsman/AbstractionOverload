class FileFlyweight
{
	public string Content { get; private set; }

	public FileFlyweight(string filePath)
	{
		if (File.Exists(filePath))
		{
			Content = File.ReadAllText(filePath);
		}
		else
		{
			Content = null;
		}
	}
}