using AbstractionOverload.Interfaces;

namespace AbstractionOverload.Models;

public class FileReader : IFileReader
{
  // Implements reading file text synchronously.
  public string ReadAllText(string path)
  {
    return File.ReadAllText(path); // Directly reads text from file.
  }
}
