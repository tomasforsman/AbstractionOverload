public class FileProcessor
{
	private FileEventStore eventStore;

	public FileProcessor(FileEventStore eventStore)
	{
		this.eventStore = eventStore;
	}

	public void ReplayEvents()
	{
		foreach (var fileEvent in eventStore.GetEvents())
		{
			fileEvent.Process();
		}
	}
}