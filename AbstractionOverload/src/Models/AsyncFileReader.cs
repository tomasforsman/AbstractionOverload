using AbstractionOverload.Interfaces;

namespace AbstractionOverload.Models;

public class AsyncFileReader : IFileReader
{
  // Implements reading file text asynchronously, synchronously returning the result.
  public string ReadAllText(string path)
  {
    return File.ReadAllTextAsync(path).Result; // Synchronously waits on the asynchronous operation.
  }
}
