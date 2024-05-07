class Program
{
	static void Main(string[] args)
	{
		var model = new FileModel { FilePath = "example.txt" };
		var view = new ConsoleView();
		var observer = new ConsoleObserver();
		model.RegisterObserver(observer);

		var fileReader = new CachedFileReader(new BasicFileReader());
		var controller = new FileController(model, view);

		controller.ReadFile(fileReader);  // Read and potentially cache the file
		controller.ReadFile(fileReader);  // Possibly fetch from cache
	}
}