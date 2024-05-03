using System;
using System.IO;

class Program
{
	static void Main(string[] args)
	{
		string filePath = "example.txt";
		LegacyFileReader legacyFileReader = new LegacyFileReader();
		FileReaderAdapter adapter = new FileReaderAdapter(legacyFileReader, filePath);

		// The client can now use the adapter to log file content through the ILogger interface
		adapter.Log("File content");
	}
}