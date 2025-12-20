using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncidentResponse.Domain.Incidents;
public enum IncidentType
{
    SecurityBreach,
    DataBreach,
    SystemOutage,
    MalwareInfection,
    PhishingAttack,
    InsiderThreat,
    PhysicalSecurityIncident,
    ComplianceViolation,
    DenialOfService,
    RansomwareAttack
}