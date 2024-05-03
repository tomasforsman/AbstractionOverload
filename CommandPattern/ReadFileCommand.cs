public class ReadFileCommand : ICommand
{
	private string _filePath;

	public ReadFileCommand(string filePath)
	{
		_filePath = filePath;
	}

	public void Execute()
	{
		if (File.Exists(_filePath))
		{
			Console.WriteLine(File.ReadAllText(_filePath));
		}
		else
		{
			Console.WriteLine("File not found.");
		}
	}
}