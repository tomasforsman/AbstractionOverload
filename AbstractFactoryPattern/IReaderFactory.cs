public interface IReaderFactory
{
	IFileReader CreateFileReader(string filePath);
}