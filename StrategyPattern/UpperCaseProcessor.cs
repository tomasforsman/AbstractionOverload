public class UpperCaseProcessor : IContentProcessor
{
	public void ProcessContent(string content)
	{
		Console.WriteLine("Upper Case Output:");
		Console.WriteLine(content.ToUpper());
	}
}