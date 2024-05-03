using AbstractionOverload.Interfaces;

namespace AbstractionOverload.Services;

public class ConsoleOutputService : IOutputService
{
  // Implements IOutputService to write messages to the console.
  public void Write(string message)
  {
    Console.WriteLine(message);
  }
}
