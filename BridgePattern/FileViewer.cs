public abstract class FileViewer
{
	protected IFileReader fileReader;

	// Constructor
	public FileViewer(IFileReader reader)
	{
		this.fileReader = reader;
	}

	public abstract void Display();
}