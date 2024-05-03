using AbstractionOverload.Interfaces;

public class ConfigurationService : IConfigurationService
{
  // Manages file configuration and notifies observers on changes.
  
  private readonly string _filePath = "example.txt"; // Default file path
  private string _fileType = "Async"; // Default file type
  private readonly List<IConfigurationObserver> _observers = new();

  // Standard getters.
  public string GetFilePath()
  {
    return Path.Combine("src", _filePath);
  }

  public string GetFileType()
  {
    return _fileType;
  }

  // Observer management.
  public void RegisterObserver(IConfigurationObserver observer)
  {
    _observers.Add(observer);
  }

  public void UnregisterObserver(IConfigurationObserver observer)
  {
    _observers.Remove(observer);
  }

  // Notifies all observers about a change.
  private void NotifyObservers()
  {
    foreach (var observer in _observers) observer.UpdateConfiguration();
  }

  // Updates the file type and notifies observers.
  public void SetFileType(string fileType)
  {
    _fileType = fileType;
    NotifyObservers();
  }
}
