public class FileOperationExecutor
{
	private ICommand _command;

	public FileOperationExecutor(ICommand command)
	{
		_command = command;
	}

	public void PerformOperation()
	{
		_command.Execute();
	}
}