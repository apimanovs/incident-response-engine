using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncidentResponse.Domain.Decisions;
public class Decision
{
    public ResponseAction Action { get; }
    public IReadOnlyList<DecisionReason>? Reasons { get; }

    public Decision(ResponseAction action, IReadOnlyList<DecisionReason>? reasons = null)
    {
        Action = action;
        Reasons = reasons;
    }
}