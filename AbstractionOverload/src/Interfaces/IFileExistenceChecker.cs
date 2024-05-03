namespace AbstractionOverload.Interfaces;

public interface IFileExistenceChecker
{
  // Checks if a file exists at the given path.
  bool FileExists(string path);
}
