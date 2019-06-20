using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Nubank.Abstractions
{
    public interface ILogger
    {
        void LogException(Exception ex, [CallerMemberName] string callerName = null);
    }
}
