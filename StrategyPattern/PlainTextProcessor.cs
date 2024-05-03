public class PlainTextProcessor : IContentProcessor
{
	public void ProcessContent(string content)
	{
		Console.WriteLine("Plain Text Output:");
		Console.WriteLine(content);
	}
}