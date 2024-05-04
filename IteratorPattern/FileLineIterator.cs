using System.Collections;

public class FileLineIterator : IEnumerator
{
	private StreamReader _reader;
	private string _currentLine;

	public FileLineIterator(string filePath)
	{
		_reader = new StreamReader(filePath);
	}

	public bool MoveNext()
	{
		_currentLine = _reader.ReadLine();
		return _currentLine != null;
	}

	public void Reset()
	{
		_reader.BaseStream.Position = 0;
		_reader.DiscardBufferedData();
	}

	public object Current => _currentLine;

	public void Dispose()
	{
		_reader.Close();
	}
}