public class FileReadEventArgs : EventArgs
{
	public string Content { get; set; }
	public Exception Error { get; set; }
	public bool Cancelled { get; set; }
}