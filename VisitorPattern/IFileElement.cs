public interface IFileElement
{
	void Accept(IFileVisitor visitor);
}