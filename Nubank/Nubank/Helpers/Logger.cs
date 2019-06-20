using Nubank.Abstractions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace Nubank.Helpers
{
    public sealed class Logger : ILogger
    {
        public void LogException(Exception ex, [CallerMemberName] string callerName = null)
        {
            Debug.WriteLine($"A error occoured at {callerName}.\n\nException details:\n{ex.Message}");
        }
    }
}
