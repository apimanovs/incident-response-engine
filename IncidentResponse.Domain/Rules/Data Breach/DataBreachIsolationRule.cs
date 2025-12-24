using IncidentResponse.Domain.Incidents;
using IncidentResponse.Domain.Risk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncidentResponse.Domain.Rules;

public class DataBreachIsolationRule : IRiskRule
{
    public bool IsApplicable(Incidents.Incident incident, System.SystemState systemState)
    {
        return incident.Type == Incidents.IncidentType.DataBreach
               && systemState.IsDataExposed;
    }

    public RiskContribution Evaluate(Incidents.Incident incident, System.SystemState systemState)
    {
        var reasons = new List<Decisions.DecisionReason>
        {
            new Decisions.DecisionReason(
                IncidentCode.DATA_EXPOSURE,
                "Data breach detected. Isolating service to prevent further data loss.",
                50
            )
        };

        return new RiskContribution(
            50,
            reasons
        );
    }
}
