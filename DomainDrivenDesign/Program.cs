class Program
{
	static void Main(string[] args)
	{
		string filePath = "example.txt";
		var fileService = new FileService();
		fileService.ReadFile(filePath);
	}
}