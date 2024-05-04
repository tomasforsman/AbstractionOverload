class ConcreteFileReader : IFileReaderPrototype
{
	public IFileReaderPrototype Clone()
	{
		// Performs a shallow copy of this object
		return this.MemberwiseClone() as IFileReaderPrototype;
	}

	public void ReadFile(string path)
	{
		// Reads the file content if file exists, otherwise prints not found message
		if (File.Exists(path))
		{
			string content = File.ReadAllText(path);
			Console.WriteLine(content);
		}
		else
		{
			Console.WriteLine("File not found.");
		}
	}
}