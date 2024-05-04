class Subscriber
{
	public Subscriber(Publisher publisher)
	{
		publisher.NotifySubscribers += DisplayMessage;
	}

	private void DisplayMessage(string message)
	{
		Console.WriteLine(message);
	}
}