using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncidentResponse.Domain.Decisions;
public enum ResponseAction
{
    IsolateService,
    RestartService,
    RolledBackDeployment,
    Escalate,
    NoActionNeeded,
}