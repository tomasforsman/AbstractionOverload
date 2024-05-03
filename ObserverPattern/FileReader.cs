public class FileReader : ISubject
{
	private List<IObserver> _observers = new List<IObserver>();
	private string _filePath;

	public FileReader(string filePath)
	{
		_filePath = filePath;
	}

	public void Attach(IObserver observer)
	{
		_observers.Add(observer);
	}

	public void Detach(IObserver observer)
	{
		_observers.Remove(observer);
	}

	public void Notify(string message)
	{
		foreach (var observer in _observers)
		{
			observer.Update(message);
		}
	}

	public void ReadFile()
	{
		if (File.Exists(_filePath))
		{
			string content = File.ReadAllText(_filePath);
			Notify(content);  // Notify observers about the content of the file
		}
		else
		{
			Notify("File not found.");
		}
	}
}