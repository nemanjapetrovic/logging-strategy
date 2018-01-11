namespace LoggingStrategy.LogModule
{
	public class Logger
	{
		private ILogType LogType;

		public Logger(ILogType logType)
		{
			this.LogType = logType;
		}

		public void Log(string logMessage)
		{
			this.LogType.Log(logMessage);
		}

		public void Log(string logMessage, ILogType logType)
		{
			this.LogType = logType;
			this.Log(logMessage);
		}
	}
}
