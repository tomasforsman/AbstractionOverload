using PostSharp.Aspects;
using PostSharp.Serialization;

[PSerializable]
public class HandleErrorAspect : OnMethodBoundaryAspect
{
	public override void OnException(MethodExecutionArgs args)
	{
		Console.WriteLine("An error occurred, please try again.");
		args.FlowBehavior = FlowBehavior.Return; // Suppresses the exception
	}
}