using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncidentResponse.Domain.Logs.Metrics;

/// <summary>
/// Represents performance and resource metrics associated with a log entry.
/// Metrics are used for trend analysis and correlation with errors.
/// </summary>
public class LogMetrics
{
    /// <summary>
    /// Execution duration in milliseconds.
    /// Often used as latency indicator.
    /// </summary>
    public int? DurationMs { get; init; }

    /// <summary>
    /// Memory usage at the time of logging.
    /// </summary>
    public int? MemoryMb { get; init; }

    /// <summary>
    /// CPU usage percentage at the time of logging.
    /// </summary>
    public int? CpuPercent { get; init; }
}
