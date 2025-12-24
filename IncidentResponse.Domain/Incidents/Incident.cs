using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncidentResponse.Domain.Incidents;
public class Incident
{
    public IncidentType Type { get; }
    public Severity? Severity { get; }
}
