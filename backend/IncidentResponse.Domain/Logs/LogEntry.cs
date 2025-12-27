using IncidentResponse.Domain.Level;
using IncidentResponse.Domain.Logs.Context;
using IncidentResponse.Domain.Logs.Error;
using IncidentResponse.Domain.Logs.Metrics;
using IncidentResponse.Domain.Trace;

/// <summary>
/// Represents a single structured log event.
/// A log entry is an immutable fact that happened at a specific point in time.
/// It contains contextual information, errors, metrics and tracing data,
/// but does NOT contain any analysis or decisions.
/// </summary>
public class LogEntry
{
    /// <summary>
    /// Unique identifier of the log entry.
    /// Useful for deduplication and referencing.
    /// </summary>
    public string Id { get; init; } = default!;

    /// <summary>
    /// Exact time when the log event occurred.
    /// This field is critical for building timelines and time windows.
    /// </summary>
    public DateTimeOffset Timestamp { get; init; }

    /// <summary>
    /// Name of the service that produced the log (e.g. orders-api).
    /// </summary>
    public string Service { get; init; } = default!;

    /// <summary>
    /// Optional component inside the service (e.g. repository, controller).
    /// </summary>
    public string? Component { get; init; }

    /// <summary>
    /// Operation or action being executed when the log was created.
    /// </summary>
    public string? Operation { get; init; }

    /// <summary>
    /// Severity level of the log.
    /// Used as a signal, not as a decision mechanism.
    /// </summary>
    public LogLevel Level { get; init; }

    /// <summary>
    /// Human-readable log message.
    /// </summary>
    public string Message { get; init; } = default!;

    /// <summary>
    /// Distributed tracing information.
    /// Allows correlating logs belonging to the same request.
    /// </summary>
    public TraceContext? Trace { get; init; }

    /// <summary>
    /// Collection of errors associated with this log entry.
    /// A single log may contain multiple related errors.
    /// </summary>
    public IReadOnlyList<LogError> Errors { get; init; } = [];

    /// <summary>
    /// Performance and resource metrics captured at the moment of logging.
    /// </summary>
    public LogMetrics? Metrics { get; init; }

    /// <summary>
    /// Additional contextual data providing details about the situation.
    /// This data is not used for logic, only for interpretation.
    /// </summary>
    public LogContext? Context { get; init; }

    /// <summary>
    /// Environment where the log was produced (e.g. production, staging).
    /// </summary>
    public string Environment { get; init; } = default!;

    /// <summary>
    /// Application version running at the time of the log.
    /// Useful for detecting post-deployment incidents.
    /// </summary>
    public string Version { get; init; } = default!;

    /// <summary>
    /// Host or node that produced the log.
    /// </summary>
    public string Host { get; init; } = default!;

    /// <summary>
    /// Arbitrary tags attached to the log for classification.
    /// </summary>
    public IReadOnlyCollection<string> Tags { get; init; } = [];
}
