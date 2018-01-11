using LoggingStrategy.LogModule;
using System;

namespace LoggingStrategy
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("File Strategy:");
			Logger logger = new Logger(new FileLog(@"C:\data.txt"));
			logger.Log("file log data");

			Console.WriteLine("\nDatabase Strategy:");
			logger.Log("database log data", new DatabaseLog());

			Console.WriteLine("\nAuditLog Strategy:");
			logger.Log("audit log data", new AuditLog());

			Console.ReadLine();
		}
	}
}
