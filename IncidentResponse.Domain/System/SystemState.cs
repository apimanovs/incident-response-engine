using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncidentResponse.Domain.System;
public class SystemState
{
    public SystemStability Stability { get; }
    public bool IsDataExposed { get; }
    int? LastDeploymentMinutesAgo { get; }
}
