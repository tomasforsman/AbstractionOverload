public class FileController
{
	private readonly FileModel _model;
	private readonly ConsoleView _view;

	public FileController(FileModel model, ConsoleView view)
	{
		_model = model;
		_view = view;
	}

	public void ReadFile(IFileReader fileReader)
	{
		var content = _model.LoadContent(fileReader.ReadFile(_model.FilePath));
		if (!string.IsNullOrEmpty(content))
		{
			_view.DisplayContent(content);
		}
		else
		{
			_view.DisplayMessage("File not found or empty.");
		}
	}
}