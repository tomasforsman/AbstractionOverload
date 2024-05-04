namespace FileReadingApp;

public class FileOperationsMediator : IMediator
{
	private FileReader _fileReader;
	private DisplayHandler _displayHandler;

	public FileOperationsMediator(string filePath)
	{
		_fileReader = new FileReader(this, filePath);
		_displayHandler = new DisplayHandler(this);
	}

	public void Notify(object sender, string eventCode)
	{
		switch (eventCode)
		{
			case "FileReadComplete":
				var content = _fileReader.Content;
				_displayHandler.Display(content);
				break;
			case "FileNotFound":
				_displayHandler.Display("File not found.");
				break;
		}
	}

	public void ReadFile()
	{
		_fileReader.ReadFileContent();
	}
}