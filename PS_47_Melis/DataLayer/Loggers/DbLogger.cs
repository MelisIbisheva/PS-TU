﻿using DataLayer.Database;
using DataLayer.Model;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Loggers
{
    public class DbLogger : ILogger

    {
        private readonly ConcurrentDictionary<int, string> _logMessages;
        private readonly string _name;

        public DbLogger(string name)
        {
            _name = name;
            _logMessages = new ConcurrentDictionary<int, string>();
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
            string dbStr = "";

            dbStr += "== Logger ==\n";
            dbStr += $"[{logLevel}]";
            dbStr += $" [{_name}]\n";
            dbStr += $"{formatter(state, exception)}\n";
            dbStr += "== Logger ==\n";

            using (var context = new DatabaseContext())
            {
                context.Logs.Add(new DatabaseLog()
                {
                    Message = dbStr
                });
                context.SaveChanges();
            }

            _logMessages[eventId.Id] = message;
        }
    }
}
