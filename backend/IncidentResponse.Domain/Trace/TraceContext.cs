using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncidentResponse.Domain.Trace;
public class TraceContext
{
    public string TraceId { get; init; } = default!;
    public string SpanId { get; init; } = default!;
}

