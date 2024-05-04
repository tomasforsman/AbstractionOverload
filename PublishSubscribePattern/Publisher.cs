class Publisher
{
	public delegate void FileReadHandler(string message);
	public event FileReadHandler NotifySubscribers;

	public void CheckFileAndPublish(string path)
	{
		if (File.Exists(path))
		{
			string content = File.ReadAllText(path);
			OnFileRead(content);
		}
		else
		{
			OnFileRead("File not found.");
		}
	}

	protected virtual void OnFileRead(string message)
	{
		NotifySubscribers?.Invoke(message);
	}
}