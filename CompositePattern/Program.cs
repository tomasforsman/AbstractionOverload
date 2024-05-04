class Program
{
	static void Main(string[] args)
	{
		string filePath = "example.txt";
		FileComponent fileComponent = new FileReader(filePath);
		fileComponent.Display();
	}
}