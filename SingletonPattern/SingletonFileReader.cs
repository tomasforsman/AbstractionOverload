public class SingletonFileReader
{
	private static SingletonFileReader _instance;
	private static readonly object _lock = new object();

	// Private constructor ensures that an object cannot be instantiated outside of the class
	private SingletonFileReader() { }

	public static SingletonFileReader Instance
	{
		get
		{
			lock (_lock)
			{
				if (_instance == null)
				{
					_instance = new SingletonFileReader();
				}
				return _instance;
			}
		}
	}

	public string ReadFile(string filePath)
	{
		if (File.Exists(filePath))
		{
			return File.ReadAllText(filePath);
		}
		else
		{
			return "File not found.";
		}
	}
}