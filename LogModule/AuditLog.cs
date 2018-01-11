using System;

namespace LoggingStrategy.LogModule
{
	public class AuditLog : ILogType
	{
		public void Log(string logMsg)
		{
			Console.WriteLine($"Audit Log Message: {logMsg}");
		}
	}
}
