interface IFileReaderPrototype
{
	// Method to clone the reader
	IFileReaderPrototype Clone();

	// Method to read file from path
	void ReadFile(string path);
}