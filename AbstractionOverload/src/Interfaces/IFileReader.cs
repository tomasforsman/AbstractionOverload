namespace AbstractionOverload.Interfaces;

public interface IFileReader
{
  // Reads all text from a file at the specified path.
  string ReadAllText(string path);
}
