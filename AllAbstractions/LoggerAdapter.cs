public class LoggerAdapter : ILogger
{
	private ThirdPartyLogger _thirdPartyLogger;

	public LoggerAdapter()
	{
		_thirdPartyLogger = new ThirdPartyLogger();
	}

	public void Log(string message)
	{
		_thirdPartyLogger.LogMessage(message);
	}
}