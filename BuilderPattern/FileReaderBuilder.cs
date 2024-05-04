class FileReaderBuilder
{
	private FileReader _fileReader = new FileReader();

	public FileReaderBuilder SetFilePath(string filePath)
	{
		_fileReader.FilePath = filePath;
		return this;
	}

	public FileReader Build()
	{
		return _fileReader;
	}
}