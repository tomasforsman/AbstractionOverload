public class ProcessFileCommand : ICommand
{
	private IContentProcessor _processor;
	private string _content;

	public ProcessFileCommand(IContentProcessor processor, string content)
	{
		_processor = processor;
		_content = content;
	}

	public void Execute()
	{
		_processor.Process(_content);
	}
}