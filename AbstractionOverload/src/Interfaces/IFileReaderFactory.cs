namespace AbstractionOverload.Interfaces;

public interface IFileReaderFactory
{
  // Factory method to create a file reader based on current configuration.
  IFileReader CreateFileReader();
}