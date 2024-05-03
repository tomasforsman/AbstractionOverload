public class LoggingReader : ContentReaderDecorator
{
	public LoggingReader(IContentReader innerReader)
		: base(innerReader)
	{
	}

	public override string ReadContent()
	{
		Console.WriteLine("Reading file content...");
		var content = base.ReadContent();
		Console.WriteLine("File content read successfully.");
		return content;
	}
}