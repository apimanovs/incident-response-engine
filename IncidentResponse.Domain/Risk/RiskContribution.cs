using IncidentResponse.Domain.Decisions;

namespace IncidentResponse.Domain.Risk;

/// <summary>
/// Represents a single contribution to the total risk.
/// Created by ONE risk rule.
/// </summary>
public class RiskContribution
{
    /// <summary>
    /// Numeric risk value (e.g. +60).
    /// </summary>
    public int Value { get; }

    /// <summary>
    /// Reasons explaining why this risk was added.
    /// Usually one reason, but stored as a list for extensibility.
    /// </summary>
    public IReadOnlyList<DecisionReason> Reasons { get; }

    public RiskContribution(int value, IReadOnlyList<DecisionReason> reasons)
    {
        Value = value;
        Reasons = reasons;
    }
}
