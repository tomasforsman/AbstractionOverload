public class SyncReaderFactory : IReaderFactory
{
	public IFileReader CreateFileReader(string filePath)
	{
		return new SyncFileReader(filePath);
	}
}