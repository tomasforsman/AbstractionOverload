using System.ComponentModel;

public class FileReader
{
	public event EventHandler<FileReadEventArgs> FileReadCompleted;

	private string _filePath;
	private BackgroundWorker _worker;

	public FileReader(string filePath)
	{
		_filePath = filePath;
		_worker = new BackgroundWorker();
		_worker.DoWork += Worker_DoWork;
		_worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
	}

	public void ReadFileAsync()
	{
		if (!_worker.IsBusy)
			_worker.RunWorkerAsync();
	}

	private void Worker_DoWork(object sender, DoWorkEventArgs e)
	{
		if (!File.Exists(_filePath))
		{
			throw new FileNotFoundException("File not found.");
		}
		string content = File.ReadAllText(_filePath);
		e.Result = content;
	}

	private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		var args = new FileReadEventArgs
		{
			Content = e.Result as string,
			Error = e.Error,
			Cancelled = e.Cancelled
		};

		FileReadCompleted?.Invoke(this, args);
	}
}