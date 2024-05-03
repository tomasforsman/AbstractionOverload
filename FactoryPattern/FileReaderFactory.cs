public class FileReaderFactory
{
	// Factory method that creates file readers
	public static IFileReader CreateFileReader(string filePath)
	{
		// Here, you can add conditions to choose different types of readers
		// based on file extension, file size, or other parameters
		return new TextFileReader(filePath);
	}
}