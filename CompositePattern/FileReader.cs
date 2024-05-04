class FileReader : FileComponent
{
	private string filePath;

	public FileReader(string filePath)
	{
		this.filePath = filePath;
	}

	public override void Display()
	{
		if (File.Exists(this.filePath))
		{
			string content = File.ReadAllText(this.filePath);
			Console.WriteLine(content);
		}
		else
		{
			new FileNotFound().Display();
		}
	}
}