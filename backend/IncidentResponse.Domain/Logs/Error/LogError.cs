using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncidentResponse.Domain.Logs.Error;
/// <summary>
/// Represents a single error captured in a log entry.
/// Errors are modeled as separate entities to allow grouping,
/// correlation and trend analysis.
/// </summary>
public class LogError
{
    /// <summary>
    /// Type of the error or exception (e.g. TimeoutException).
    /// </summary>
    public string Type { get; init; } = default!;

    /// <summary>
    /// Error message describing what went wrong.
    /// </summary>
    public string Message { get; init; } = default!;

    /// <summary>
    /// Optional stack trace for debugging and deeper analysis.
    /// </summary>
    public string? StackTrace { get; init; }

    /// <summary>
    /// Optional error code used for categorization.
    /// </summary>
    public string? Code { get; init; }
}
