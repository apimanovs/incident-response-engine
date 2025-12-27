/// <summary>
/// Represents a fixed time interval containing log entries.
/// Time windows are the foundation of time-based analysis,
/// allowing comparison between different periods.
/// </summary>
public class TimeWindow
{
    /// <summary>
    /// Start of the time window (inclusive).
    /// </summary>
    public DateTimeOffset From { get; init; }

    /// <summary>
    /// End of the time window (exclusive).
    /// </summary>
    public DateTimeOffset To { get; init; }

    /// <summary>
    /// Log entries that occurred within this time window.
    /// </summary>
    public IReadOnlyList<LogEntry> Entries { get; init; } = default!;
}
