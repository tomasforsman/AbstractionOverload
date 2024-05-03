using AbstractionOverload.Interfaces;

namespace AbstractionOverload.Services;

public class FileExistenceChecker : IFileExistenceChecker
{
  // Checks file existence using the system file checker.
  public bool FileExists(string path)
  {
    return File.Exists(path);
  }
}
