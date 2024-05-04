using Metalama.Framework;

class Program
{
	static void Main(string[] args)
	{
		var filePath = "example.txt";
		var reader = new FileReader(filePath);
		reader.ReadFile();
		reader = new FileReader("nonexistent.txt");
		reader.ReadFile();
	}
}

