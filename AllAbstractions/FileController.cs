using Serilog;

public class FileController
{
	private readonly FileModel _model;
	private readonly ConsoleView _view;

	public FileController(FileModel model, ConsoleView view)
	{
		_model = model;
		_view = view;
	}

	public async Task ReadFileAsync(IFileReader fileReader)
	{
		Log.Debug("Attempting to read file at {FilePath}", _model.FilePath);
		try
		{
			var content = await _model.LoadContentAsync(await fileReader.ReadFileAsync(_model.FilePath));
			if (!string.IsNullOrEmpty(content))
			{
				_view.DisplayContent(content);
				Log.Information("File read successfully.");
			}
			else
			{
				_view.DisplayMessage("File not found or empty.");
				Log.Warning("File at {FilePath} was empty or not found.", _model.FilePath);
			}
		}
		catch (Exception ex)
		{
			Log.Error(ex, "Failed to read file at {FilePath}", _model.FilePath);
			_view.DisplayMessage("Error occurred while reading file.");
		}
	}
}