public class FileOperationsFacade
{
	private FileReader _fileReader;
	private ContentDisplayer _contentDisplayer;

	public FileOperationsFacade()
	{
		_fileReader = new FileReader();
		_contentDisplayer = new ContentDisplayer();
	}

	public void ReadAndDisplayFile(string filePath)
	{
		string content = _fileReader.ReadFile(filePath);
		_contentDisplayer.DisplayContent(content);
	}
}