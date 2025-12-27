using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncidentResponse.Domain.Level;
/// <summary>
/// Defines the severity level of a log entry.
/// Log levels are treated as signals, not as decision triggers.
/// </summary>
public enum LogLevel
{
    /// <summary>
    /// Informational message describing normal system behavior.
    /// </summary>
    Info,

    /// <summary>
    /// Warning indicating a potential issue or degradation.
    /// </summary>
    Warning,

    /// <summary>
    /// Error indicating a failure affecting system functionality.
    /// </summary>
    Error
}
