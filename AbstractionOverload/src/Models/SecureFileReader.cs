using AbstractionOverload.Interfaces;

namespace AbstractionOverload.Models;

public class SecureFileReader : IFileReader
{
  // Could potentially implement additional security checks or encryption handling.
  public string ReadAllText(string path)
  {
    return File.ReadAllText(path); // For now, behaves like FileReader.
  }
}
