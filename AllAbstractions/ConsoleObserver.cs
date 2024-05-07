public class ConsoleObserver : IObserver
{
	public void Update(string message)
	{
		Console.WriteLine($"Notification: {message}");
	}
}