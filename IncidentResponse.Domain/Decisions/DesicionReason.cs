using IncidentResponse.Domain.Incidents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncidentResponse.Domain.Decisions;

public class DecisionReason
{
    public IncidentCode? Code { get; }
    public string? Message { get; }
    public int Weight { get; }

    public DecisionReason (IncidentCode? code, string? message, int weight = 0)
    {
        Code = code;
        Message = message;
        Weight = weight;
    }
}
