﻿public class ConsoleObserver : IObserver
{
	public void Update(string message)
	{
		Console.WriteLine($"Observer Notification: {message}");
	}
}