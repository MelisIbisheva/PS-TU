using Microsoft.Extensions.Logging;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeExtended.Loggers
{
    public class FileLogger : ILogger
    {
     
        private readonly string _filePath;

        public FileLogger(string filePath)
        {
            _filePath = filePath;
        }

        public IDisposable? BeginScope<TState>(TState state) where TState : notnull
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            var message = formatter(state, exception);
            WriteLogToFile(message);

           
        }

        public void WriteLogToFile(string logMessage)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(_filePath, true))
                {
                    sw.WriteLine($"[{DateTime.Now}] - {logMessage}");

                }
            }catch (Exception ex)
            {
                Console.WriteLine($"Error writing to log file: { ex.Message}");
            }
        }
    }
}
