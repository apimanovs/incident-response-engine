using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncidentResponse.Domain.Incidents;
public class Severity
{
    public int Value { get; }

    public Severity(int value)
    {
        if (value < 1 || value > 5)
        {
            throw new ArgumentOutOfRangeException(nameof(value), "Severity must be between 1 and 5.");
        }

        this.Value = value;
    }
}