﻿public class FileReader
{
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