public class FileModel : ISubject
{
	private List<IObserver> _observers = new List<IObserver>();
	public string FilePath { get; set; }
	private string _content;

	public string LoadContent(string content)
	{
		if (!string.IsNullOrEmpty(content) && content != _content)
		{
			_content = content;
			NotifyObservers("Content updated");
		}
		else
		{
			NotifyObservers("No change in content");
		}
		return _content;
	}

	public void RegisterObserver(IObserver observer)
	{
		_observers.Add(observer);
	}

	public void RemoveObserver(IObserver observer)
	{
		_observers.Remove(observer);
	}

	public void NotifyObservers(string message)
	{
		foreach (var observer in _observers)
		{
			observer.Update(message);
		}
	}
}