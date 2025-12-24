using IncidentResponse.Domain.Decisions;
using IncidentResponse.Domain.Incidents;
using IncidentResponse.Domain.Risk;
using IncidentResponse.Domain.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncidentResponse.Domain.Rules;
public interface IRiskRule
{
    bool IsApplicable(Incident incident, SystemState systemState);
    RiskContribution Evaluate(Incident incident, SystemState systemState);
}
