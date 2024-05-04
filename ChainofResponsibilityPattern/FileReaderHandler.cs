class FileReaderHandler : AbstractHandler
{
	public override void Handle(string filePath)
	{
		string content = File.ReadAllText(filePath);
		Console.WriteLine(content);
		base.Handle(filePath);  // Optionally pass control to further handlers, e.g., logging.
	}
}