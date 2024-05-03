namespace AbstractionOverload.Interfaces;

public interface IConfigurationService
{
  // Retrieves the file path from configuration.
  string GetFilePath();

  // Retrieves the file type from configuration.
  string GetFileType();
}