using System.Reflection;

public class ContentProcessorFactory : IContentProcessorFactory
{
	public IContentProcessor GetContentProcessor(string type)
	{
		var processorType = Assembly.GetExecutingAssembly().GetTypes()
			.FirstOrDefault(t => t.Name.Equals(type + "Processor", StringComparison.OrdinalIgnoreCase));
		if (processorType != null)
		{
			return Activator.CreateInstance(processorType) as IContentProcessor;
		}
		throw new ArgumentException($"Unknown Content Processor type: {type}");
	}
}