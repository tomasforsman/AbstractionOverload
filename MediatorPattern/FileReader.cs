namespace FileReadingApp;

public class FileReader
{
	private IMediator _mediator;
	public string FilePath { get; private set; }
	public string Content { get; private set; }

	public FileReader(IMediator mediator, string filePath)
	{
		_mediator = mediator;
		FilePath = filePath;
	}

	public void ReadFileContent()
	{
		if (File.Exists(FilePath))
		{
			Content = File.ReadAllText(FilePath);
			_mediator.Notify(this, "FileReadComplete");
		}
		else
		{
			_mediator.Notify(this, "FileNotFound");
		}
	}
}