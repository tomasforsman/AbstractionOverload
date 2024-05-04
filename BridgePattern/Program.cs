class Program
{
	static void Main(string[] args)
	{
		IFileReader reader = new ConcreteFileReader();
		FileViewer viewer = new ConsoleFileViewer(reader);
		viewer.Display();
	}
}