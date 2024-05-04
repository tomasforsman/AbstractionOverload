class Program
{
	static void Main(string[] args)
	{
		string filePath = "example.txt";
		FileContext context = new FileContext(filePath);
		context.Display();
	}
}