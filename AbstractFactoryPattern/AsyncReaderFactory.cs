public class AsyncReaderFactory : IReaderFactory
{
	public IFileReader CreateFileReader(string filePath)
	{
		return new AsyncFileReader(filePath);
	}
}