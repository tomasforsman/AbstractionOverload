abstract class AbstractHandler : IHandler
{
	private IHandler _nextHandler;

	public IHandler SetNext(IHandler handler)
	{
		_nextHandler = handler;
		return handler;
	}

	public virtual void Handle(string filePath)
	{
		if (_nextHandler != null)
		{
			_nextHandler.Handle(filePath);
		}
	}
}