public class ReadFileCommand : ICommand
{
	private IFileReader _fileReader;
	private string _filePath;

	public ReadFileCommand(IFileReader fileReader, string filePath)
	{
		_fileReader = fileReader;
		_filePath = filePath;
	}

	public void Execute()
	{
		string content = _fileReader.ReadFile(_filePath);
		Console.WriteLine(content);
	}
}