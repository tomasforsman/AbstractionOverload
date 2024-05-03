using AbstractionOverload.Interfaces;
using AbstractionOverload.Models;

namespace AbstractionOverload.Services;

public class FileReaderFactory : IFileReaderFactory
{
  // Uses the configuration service to determine which FileReader to create.
  
  private readonly IConfigurationService _configurationService;

  public FileReaderFactory(IConfigurationService configurationService)
  {
    _configurationService = configurationService;
  }

  // Creates a FileReader based on the file type specified in configuration.
  public IFileReader CreateFileReader()
  {
    var fileType = _configurationService.GetFileType();

    switch (fileType)
    {
      case "Async":
        return new AsyncFileReader();

      case "Secure":
        return new SecureFileReader();

      default:
        return new FileReader();
    }
  }
}
