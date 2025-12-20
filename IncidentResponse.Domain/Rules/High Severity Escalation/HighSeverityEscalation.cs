using IncidentResponse.Domain.Incidents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncidentResponse.Domain.Rules.High_Severity_Escalation;
public class HighSeverityEscalation : IDecisionRule
{
    public bool IsApplicable(Incidents.Incident incident, System.SystemState systemState)
    {
        return incident.Severity?.Value >= 4;
    }

    public Decisions.Decision Evaluate(Incidents.Incident incident, System.SystemState systemState)
    {
        var reasons = new List<Decisions.DecisionReason>
        {
            new Decisions.DecisionReason(
                IncidentCode.HIGH_SEVERITY,
                "Incident severity is high. Escalating to senior response team.",
                40
            )
        };

        return new Decisions.Decision(
            Decisions.ResponseAction.Escalate,
            reasons
        );
    }
}
