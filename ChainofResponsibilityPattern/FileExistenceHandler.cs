class FileExistenceHandler : AbstractHandler
{
	public override void Handle(string filePath)
	{
		if (!File.Exists(filePath))
		{
			Console.WriteLine("File not found.");
			return;  // Stop chain if file does not exist.
		}
		base.Handle(filePath);  // Pass control to the next handler if file exists.
	}
}