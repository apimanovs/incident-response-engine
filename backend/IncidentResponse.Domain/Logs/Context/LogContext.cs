using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncidentResponse.Domain.Logs.Context;

/// <summary>
/// Represents additional contextual data attached to a log entry.
/// Context provides situational details but is not used in analysis logic.
/// </summary>
public class LogContext
{
    /// <summary>
    /// Arbitrary key-value data describing the context
    /// (e.g. userId, orderId, retryAttempt).
    /// </summary>
    public Dictionary<string, object> Data { get; init; } = [];
}
