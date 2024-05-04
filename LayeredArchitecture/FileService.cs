namespace FileReadingApp;

public class FileService
{
	private IFileReader fileReader;

	public FileService()
	{
		this.fileReader = new FileReader();  // Dependency can also be injected.
	}

	public string ReadFile(string filePath)
	{
		return fileReader.ReadFileContent(filePath);
	}
}