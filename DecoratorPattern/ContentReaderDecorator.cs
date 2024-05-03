public abstract class ContentReaderDecorator : IContentReader
{
	protected IContentReader _innerReader;

	public ContentReaderDecorator(IContentReader innerReader)
	{
		_innerReader = innerReader;
	}

	public virtual string ReadContent()
	{
		return _innerReader.ReadContent();
	}
}