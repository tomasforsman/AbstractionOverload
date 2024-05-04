public class SyncFileReader : IFileReader
{
	private string filePath;

	public SyncFileReader(string filePath)
	{
		this.filePath = filePath;
	}

	public string ReadFile()
	{
		if (File.Exists(filePath))
		{
			return File.ReadAllText(filePath);
		}
		else
		{
			return "File not found.";
		}
	}
}