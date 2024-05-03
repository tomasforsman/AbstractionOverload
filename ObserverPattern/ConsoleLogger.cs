public class ConsoleLogger : IObserver
{
	public void Update(string message)
	{
		Console.WriteLine("Notification received: " + message);
	}
}