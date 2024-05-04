public class ConsoleFileViewer : FileViewer
{
	public ConsoleFileViewer(IFileReader reader) : base(reader)
	{
	}

	public override void Display()
	{
		string filePath = "example.txt";
		string content = fileReader.ReadFile(filePath);
		Console.WriteLine(content);
	}
}