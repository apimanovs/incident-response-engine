namespace IncidentResponse.Domain.Window;

/// <summary>
/// Represents aggregated numeric metrics for a single time window.
/// This class describes what happened during a specific time period
/// using raw numbers only, without interpretation or conclusions.
/// </summary>
public class WindowMetrics
{
    /// <summary>
    /// Total number of log entries recorded in this time window.
    /// </summary>
    public int TotalLogs { get; init; }

    /// <summary>
    /// Number of log entries with severity level Error.
    /// Represents functional failures observed in this window.
    /// </summary>
    public int ErrorLogs { get; init; }

    /// <summary>
    /// Number of log entries with severity level Warning.
    /// Often indicates early signs of degradation.
    /// </summary>
    public int WarningCount { get; init; }

    /// <summary>
    /// Average execution duration (latency) in milliseconds.
    /// Null if no duration metrics were present in this window.
    /// </summary>
    public double? AverageDurationMs { get; init; }

    /// <summary>
    /// Average memory usage (in megabytes) observed during this window.
    /// Null if no memory metrics were recorded.
    /// </summary>
    public double? AverageMemoryMb { get; init; }

    /// <summary>
    /// Error types observed in this time window along with their occurrence count.
    /// Used for identifying dominant or emerging failure patterns.
    /// </summary>
    public IReadOnlyDictionary<string, int> ErrorTypes { get; init; } =
        new Dictionary<string, int>();

    /// <summary>
    /// Services that produced log entries in this window along with their count.
    /// Useful for identifying which services were most active.
    /// </summary>
    public IReadOnlyDictionary<string, int> Services { get; init; } =
        new Dictionary<string, int>();
}
