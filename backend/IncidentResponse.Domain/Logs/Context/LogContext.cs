using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncidentResponse.Domain.Logs.Context;
public class LogContext
{
    public Dictionary<string, object> Data { get; init; } = [];
}
