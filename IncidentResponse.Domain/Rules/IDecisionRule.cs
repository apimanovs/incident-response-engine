using IncidentResponse.Domain.Decisions;
using IncidentResponse.Domain.Incidents;
using IncidentResponse.Domain.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncidentResponse.Domain.Rules;
public interface IDecisionRule
{
    bool IsApplicable(Incident incident, SystemState systemState);
    Decision Evaluate(Incident incident, SystemState systemState);
}
