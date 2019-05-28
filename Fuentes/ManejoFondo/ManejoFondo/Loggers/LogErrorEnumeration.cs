using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoFondo.Loggers
{
    public enum LogErrorEnumeration
    {
        Error = System.Diagnostics.TraceEventType.Error,
        Informacion = System.Diagnostics.TraceEventType.Information,
        Critico = System.Diagnostics.TraceEventType.Critical,
        Start = System.Diagnostics.TraceEventType.Start,
        Stop = System.Diagnostics.TraceEventType.Stop,
    }
}
