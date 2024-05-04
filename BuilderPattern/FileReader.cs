class FileReader
{
	public string FilePath { get; set; }
	public string Content { get; private set; }

	public bool ReadFile()
	{
		if (File.Exists(this.FilePath))
		{
			this.Content = File.ReadAllText(this.FilePath);
			return true;
		}
		else
		{
			this.Content = "File not found.";
			return false;
		}
	}
}