using System;
using NLog;
using System.Threading;

namespace LoggingApp
{
	class Program
	{
		private static Logger logger = LogManager.GetCurrentClassLogger();

		static void Main(string[] args)
		{
			while (true)
			{
				logger.Warn("Successfully logged from \"{0}\"", Environment.MachineName);
				Thread.Sleep(30000);
			}
		}
	}
}
