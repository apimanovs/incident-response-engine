using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncidentResponse.Domain.Logs.Error;
public class LogError
{
    public string Type { get; init; } = default!;
    public string Message { get; init; } = default!;
    public string? StackTrace { get; init; }

    public string? Code { get; init; }
}

