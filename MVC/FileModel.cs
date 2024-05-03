public class FileModel
{
	public string FilePath { get; set; }
	public string Content { get; set; }

	public bool ReadFile()
	{
		if (File.Exists(FilePath))
		{
			Content = File.ReadAllText(FilePath);
			return true;
		}
		else
		{
			Content = "File not found.";
			return false;
		}
	}
}