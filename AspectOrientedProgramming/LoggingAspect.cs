using PostSharp.Aspects;
using PostSharp.Serialization;

[PSerializable]
public class LoggingAspect : OnMethodBoundaryAspect
{
	public override void OnEntry(MethodExecutionArgs args)
	{
		Console.WriteLine($"Entering {args.Method.Name}.");
	}

	public override void OnExit(MethodExecutionArgs args)
	{
		Console.WriteLine($"Exiting {args.Method.Name}.");
	}

	public override void OnException(MethodExecutionArgs args)
	{
		Console.WriteLine($"Exception in {args.Method.Name}: {args.Exception.Message}");
	}
}