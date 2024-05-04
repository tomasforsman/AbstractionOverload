interface IHandler
{
	IHandler SetNext(IHandler handler);
	void Handle(string filePath);
}