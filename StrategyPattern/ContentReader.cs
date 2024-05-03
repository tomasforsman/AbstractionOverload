public class ContentReader
{
	private readonly IContentProcessor _processor;

	public ContentReader(IContentProcessor processor)
	{
		_processor = processor;
	}

	public void ReadAndProcessContent(string filePath)
	{
		if (File.Exists(filePath))
		{
			string content = File.ReadAllText(filePath);
			_processor.ProcessContent(content);
		}
		else
		{
			Console.WriteLine("File not found.");
		}
	}
}