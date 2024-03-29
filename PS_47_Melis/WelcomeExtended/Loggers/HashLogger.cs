﻿using Microsoft.Extensions.Logging;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeExtended.Loggers
{
    public class HashLogger : ILogger
    {
        private readonly ConcurrentDictionary<int, string> _logMessages;
        private readonly string _name;

        public HashLogger (string name)
        {
            _name = name;
            _logMessages = new ConcurrentDictionary<int, string> ();
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            //This logger does not support scopes.
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            //This logger is always enabled.
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            var message = formatter(state, exception);
            switch(logLevel)
            {
                case LogLevel.Critical:
                    Console.ForegroundColor = ConsoleColor.Red; break;
                case LogLevel.Error:
                    Console.ForegroundColor = ConsoleColor.DarkRed; break;
                case LogLevel.Warning:
                    Console.ForegroundColor = ConsoleColor.Yellow; break;
                default:
                    Console.ForegroundColor = ConsoleColor.White; break;
; 
            }
            Console.WriteLine("- LOGGER -");
            var messageToBeLogged = new StringBuilder ();
            messageToBeLogged.Append($"[{logLevel}]");
            messageToBeLogged.AppendFormat(" [{0}]", _name);
            Console.WriteLine(messageToBeLogged);
            Console.WriteLine($" {formatter(state, exception)}");
            Console.WriteLine("- LOGGER -");
            Console.ResetColor();
            _logMessages[eventId.Id] = message;

            
        }

        public void PrintLoggedMessages()
        {
            Console.WriteLine("All logged messages:");
            foreach (var message in _logMessages.Values)
            {
                Console.WriteLine(message);
            }
        }

        public void PrintByEventId(int eventId)
        {
            if (_logMessages.ContainsKey(eventId))
            {
                var message = _logMessages[eventId];
                Console.WriteLine($"Message for EventId {eventId}: {message}");
            }
            else
            {
                Console.WriteLine($"No message found for EventId {eventId}");
            }
        }

        public void RemoveEventById(int eventId)
        {
            if (_logMessages.ContainsKey(eventId))
            {
                _logMessages.Remove(eventId, out _);
                Console.WriteLine($"EventId {eventId} removed from the log.");
            }
            else
            {
                Console.WriteLine($"EventId {eventId} not found in the log.");
            }
        }

    }
}
