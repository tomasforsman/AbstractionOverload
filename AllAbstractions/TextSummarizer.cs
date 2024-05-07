public class TextSummarizer : IContentProcessor
{
	public void Process(string content)
	{
		// Example: Summarize the content
		Console.WriteLine("Summarizing content...");
		Console.WriteLine(content.Substring(0, Math.Min(100, content.Length)) + "...");
	}
}