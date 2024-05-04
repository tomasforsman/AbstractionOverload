namespace FileReadingApp;

public class DisplayHandler
{
	private IMediator _mediator;

	public DisplayHandler(IMediator mediator)
	{
		_mediator = mediator;
	}

	public void Display(string message)
	{
		Console.WriteLine(message);
	}
}