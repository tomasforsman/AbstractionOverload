public class FileController
{
	private FileModel _model;
	private FileView _view;

	public FileController(FileModel model, FileView view)
	{
		_model = model;
		_view = view;
	}

	public void DisplayFile()
	{
		bool success = _model.ReadFile();
		if (success)
		{
			_view.DisplayContent(_model.Content);
		}
		else
		{
			_view.DisplayContent(_model.Content);
		}
	}
}