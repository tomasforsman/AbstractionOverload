public class ContentProcessorFactory : IContentProcessorFactory
{
	private static ContentProcessorFactory _instance;

	private ContentProcessorFactory() {}

	public static ContentProcessorFactory Instance
	{
		get
		{
			if (_instance == null)
			{
				_instance = new ContentProcessorFactory();
			}
			return _instance;
		}
	}

	public IContentProcessor GetContentProcessor(string type)
	{
		switch (type.ToLower())
		{
			case "json":
				return new JsonProcessor();
			case "summary":
				return new TextSummarizer();
			default:
				throw new ArgumentException("Unknown Content Processor type.");
		}
	}
}