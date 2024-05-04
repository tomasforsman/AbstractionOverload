using Metalama.Framework.Aspects;

// Meta Lama Error Handling Attribute
public class HandleErrorAttribute : OverrideMethodAspect
{
		public override dynamic? OverrideMethod()
		{
				try
				{
						return meta.Proceed();
				}
				catch (Exception ex)
				{
						Console.WriteLine($"Error: {ex.Message}");
						return null;
				}
		}
}