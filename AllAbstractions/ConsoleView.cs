public class ConsoleView
{
	public void DisplayContent(string content)
	{
		if (string.IsNullOrEmpty(content))
		{
			Console.WriteLine("File not found or empty.");
		}
		else
		{
			Console.WriteLine(content);
		}
	}

	public void DisplayMessage(string message)
	{
		Console.WriteLine(message);
	}
}