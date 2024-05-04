class FileService
{
	public void ReadFile(string filePath)
	{
		var textFile = new TextFile(filePath);
		try
		{
			textFile.LoadContent();
			textFile.DisplayContent();
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}
}