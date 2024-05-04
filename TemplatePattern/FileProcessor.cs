abstract class FileProcessor
{
	public void ProcessFile(string filePath)
	{
		if (File.Exists(filePath))
		{
			string content = ReadFile(filePath);
			ProcessContent(content);
		}
		else
		{
			HandleFileNotFound();
		}
	}

	protected virtual string ReadFile(string filePath)
	{
		return File.ReadAllText(filePath);
	}

	protected abstract void ProcessContent(string content);

	protected virtual void HandleFileNotFound()
	{
		Console.WriteLine("File not found.");
	}
}