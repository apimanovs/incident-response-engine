using IncidentResponse.Domain.Incidents;
using IncidentResponse.Domain.Rules;
using IncidentResponse.Domain.System;

using IncidentResponse.Application.Policies;

namespace IncidentResponse.Domain.Decisions.Engine;

public class DecisionEngine : RiskPolicy
{
    private readonly IEnumerable<IRiskRule> _rules;

    public DecisionEngine(IEnumerable<IRiskRule> rules)
    {
        _rules = rules;
    }

    public Decision CalculateRisks(Incident incident, SystemState systemState)
    { 
        var riskContributions = new List<Risk.RiskContribution>();

        foreach (var rule in _rules)
        {
            if (rule.IsApplicable(incident, systemState))
            {
                var risk = rule.Evaluate(incident, systemState);
                riskContributions.Add(risk);
            }
        }
        
        var totalRisk = riskContributions.Sum(c => c.Value);
        
        var reasons = riskContributions.SelectMany(c => c.Reasons).ToList();

        var action = SelectAction(totalRisk);

        return new Decision(
            action,
            reasons
        );
    }
}
