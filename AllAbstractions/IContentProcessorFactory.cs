public interface IContentProcessorFactory
{
	IContentProcessor GetContentProcessor(string type);
}