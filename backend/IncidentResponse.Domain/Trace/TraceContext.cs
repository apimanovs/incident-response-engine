using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncidentResponse.Domain.Trace;

/// <summary>
/// Represents distributed tracing information.
/// Trace context allows correlating multiple log entries
/// belonging to the same request across different services.
/// </summary>
public class TraceContext
{
    /// <summary>
    /// Identifier of the entire request or transaction.
    /// All logs with the same TraceId belong to one request.
    /// </summary>
    public string TraceId { get; init; } = default!;

    /// <summary>
    /// Identifier of a single operation or step within the trace.
    /// </summary>
    public string SpanId { get; init; } = default!;
}


