class Program
{
	static void Main(string[] args)
	{
		string filePath = "example.txt";
		FileModel model = new FileModel() { FilePath = filePath };
		FileView view = new FileView();
		FileController controller = new FileController(model, view);

		controller.DisplayFile();
	}
}