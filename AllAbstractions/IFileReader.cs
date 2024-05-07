public interface IFileReader
{
	Task<string> ReadFileAsync(string path);
}