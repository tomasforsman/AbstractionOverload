public class TextFile : IFileElement
{
	public string FilePath { get; }

	public TextFile(string filePath)
	{
		FilePath = filePath;
	}

	public void Accept(IFileVisitor visitor)
	{
		visitor.Visit(this);
	}
}