using System;
using System.IO;

class Program
{
	static void Main(string[] args)
	{
		string filePath = "example.txt";
		RealFileReader realFileReader = new RealFileReader();
		CachedFileReader cachedFileReader = new CachedFileReader(realFileReader);

		// Use the proxy to read the file
		Console.WriteLine(cachedFileReader.ReadFile(filePath));
		// Use the proxy again to see the cache in action
		Console.WriteLine(cachedFileReader.ReadFile(filePath));
	}
}