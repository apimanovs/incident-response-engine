using IncidentResponse.Domain.Logs.Context;
using IncidentResponse.Domain.Logs.Error;
using IncidentResponse.Domain.Logs.Metrics;
using IncidentResponse.Domain.Level;
using IncidentResponse.Domain.Trace;


namespace IncidentResponse.Domain.Models;
public class LogEntry
{
    public string Id { get; init; } = default!;
    public DateTimeOffset Timestamp { get; init; }

    public string Service { get; init; } = default!;
    public string? Component { get; init; }
    public string? Operation { get; init; }

    public LogLevel Level { get; init; }
    public string Message { get; init; } = default!;

    public TraceContext? Trace { get; init; }

    public IReadOnlyList<LogError> Errors { get; init; } = [];
    public LogMetrics? Metrics { get; init; }
    public LogContext? Context { get; init; }

    public string Environment { get; init; } = default!;
    public string Version { get; init; } = default!;
    public string Host { get; init; } = default!;

    public IReadOnlyCollection<string> Tags { get; init; } = [];
}

