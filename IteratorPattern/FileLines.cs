using System.Collections;

public class FileLines : IEnumerable
{
	private string _filePath;
	private bool _reverse;

	public FileLines(string filePath, bool reverse = false)
	{
		_filePath = filePath;
		_reverse = reverse;
	}

	public IEnumerator GetEnumerator()
	{
		if (_reverse)
			return new ReverseFileLineIterator(_filePath);
		else
			return new FileLineIterator(_filePath);
	}
}