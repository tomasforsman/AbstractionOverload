using System.Collections;

public class ReverseFileLineIterator : IEnumerator
{
	private Stack<string> lines = new Stack<string>();
	private string _currentLine;

	public ReverseFileLineIterator(string filePath)
	{
		using (var reader = new StreamReader(filePath))
		{
			string line;
			while ((line = reader.ReadLine()) != null)
			{
				lines.Push(line);
			}
		}
	}

	public bool MoveNext()
	{
		if (lines.Count > 0)
		{
			_currentLine = lines.Pop();
			return true;
		}
		return false;
	}

	public void Reset()
	{
		// Implementing this would require re-reading the file or maintaining the initial stack.
		throw new NotSupportedException("Reset is not supported.");
	}

	public object Current => _currentLine;

	public void Dispose()
	{
		// Nothing to dispose explicitly here
	}
}