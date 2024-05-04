public interface IFileEvent
{
	string FilePath { get; }
	void Process();
}