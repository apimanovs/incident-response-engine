using IncidentResponse.Domain.Decisions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncidentResponse.Application.Policies;

public class RiskPolicy
{
    public ResponseAction SelectAction(int totalRisk)
    {
        if (totalRisk >= 100) return ResponseAction.IsolateService;

        if (totalRisk >= 60) return ResponseAction.Escalate;

        if (totalRisk >= 30) return ResponseAction.RolledBackDeployment;

        return ResponseAction.NoActionNeeded;
    }
}

