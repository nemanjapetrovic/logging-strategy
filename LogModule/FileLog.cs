using System;

namespace LoggingStrategy.LogModule
{
	public class FileLog : ILogType
	{
		private string FilePath { get; set; }
		public FileLog(string filePath)
		{
			this.FilePath = filePath;
		}

		public void Log(string logMsg)
		{
			Console.WriteLine($"File Log Message: {logMsg}");
		}
	}
}
