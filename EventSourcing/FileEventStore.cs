public class FileEventStore
{
	private List<IFileEvent> events = new List<IFileEvent>();

	public void AddEvent(IFileEvent fileEvent)
	{
		events.Add(fileEvent);
	}

	public IEnumerable<IFileEvent> GetEvents()
	{
		return events;
	}
}