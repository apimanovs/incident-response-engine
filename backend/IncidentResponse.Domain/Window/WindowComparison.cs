namespace IncidentResponse.Domain.Window;

/// <summary>
/// Represents a comparison between two consecutive time windows.
/// This class stores differences between aggregated metrics
/// in order to describe how system behavior changed over time.
/// 
/// It does NOT calculate values and does NOT make conclusions.
/// All values are expected to be provided by a comparison builder.
/// </summary>
public class WindowComparison
{
    /// <summary>
    /// Aggregated metrics of the current (later) time window.
    /// </summary>
    public WindowMetrics CurrentWindow { get; init; } = default!;

    /// <summary>
    /// Aggregated metrics of the previous (earlier) time window.
    /// </summary>
    public WindowMetrics PreviousWindow { get; init; } = default!;

    /// <summary>
    /// Difference in the number of error logs between the two windows.
    /// Positive value means an increase in errors.
    /// </summary>
    public int DeltaErrorLogs { get; init; }

    /// <summary>
    /// Difference in average execution duration (latency) in milliseconds.
    /// Positive value means increased latency.
    /// </summary>
    public double? DeltaAverageDurationMs { get; init; }

    /// <summary>
    /// Multiplier showing how the error rate changed
    /// compared to the previous window (e.g. 6.0 means 6x increase).
    /// </summary>
    public double? ErrorRateMultiplier { get; init; }

    /// <summary>
    /// Error types that appeared in the current window
    /// but were not present in the previous one.
    /// </summary>
    public IReadOnlyCollection<string> NewErrorTypes { get; init; } = [];

    /// <summary>
    /// Service that became the dominant source of logs
    /// compared to the previous window.
    /// </summary>
    public string? NewTopService { get; init; }
}
