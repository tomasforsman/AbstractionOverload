public class JsonProcessor : IContentProcessor
{
	public void Process(string content)
	{
		Console.WriteLine($"Processing as JSON: {content}");
	}
}