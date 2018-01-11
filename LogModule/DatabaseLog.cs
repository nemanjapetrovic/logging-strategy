using System;

namespace LoggingStrategy.LogModule
{
	public class DatabaseLog : ILogType
	{
		public void Log(string logMsg)
		{
			Console.WriteLine($"Database Log Message: {logMsg}");
		}
	}
}
