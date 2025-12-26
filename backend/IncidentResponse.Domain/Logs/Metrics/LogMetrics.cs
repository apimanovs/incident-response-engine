using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncidentResponse.Domain.Logs.Metrics;
public class LogMetrics
{
    public int? DurationMs { get; init; }
    public int? MemoryMb { get; init; }
    public int? CpuPercent { get; init; }
}

