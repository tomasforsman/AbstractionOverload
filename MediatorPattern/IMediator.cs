namespace FileReadingApp;

public interface IMediator
{
	void Notify(object sender, string eventCode);
}