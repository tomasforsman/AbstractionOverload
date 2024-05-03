class Program
{
	static void Main(string[] args)
	{
		string filePath = "example.txt";
		FileOperationsFacade facade = new FileOperationsFacade();
		facade.ReadAndDisplayFile(filePath);
	}
}