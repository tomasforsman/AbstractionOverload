class Program
{
	static void Main(string[] args)
	{
		string filePath = "example.txt";
		FileFlyweightFactory factory = new FileFlyweightFactory();
		FileFlyweight flyweight = factory.GetFlyweight(filePath);

		if (flyweight.Content == null)
		{
			Console.WriteLine("File not found.");
		}
		else
		{
			Console.WriteLine(flyweight.Content);
		}
	}
}