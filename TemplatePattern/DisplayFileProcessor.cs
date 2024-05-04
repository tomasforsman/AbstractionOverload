class DisplayFileProcessor : FileProcessor
{
	protected override void ProcessContent(string content)
	{
		Console.WriteLine(content);
	}

	// Optionally override other methods if different behavior is needed
}