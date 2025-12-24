using IncidentResponse.Domain.Incidents;

namespace IncidentResponse.Domain.Decisions;

/// <summary>
/// Represents a single reason explaining WHY a decision or risk was produced.
/// 
/// This class contains no logic.
/// It is used only for explainability and analysis.
/// </summary>
public class DecisionReason
{
    /// <summary>
    /// Code identifying the reason.
    /// Used for analytics, logging and what-if analysis.
    /// </summary>
    public IncidentCode Code { get; }

    /// <summary>
    /// Human-readable explanation of the reason.
    /// This text can be shown to a user or operator.
    /// </summary>
    public string Message { get; }

    /// <summary>
    /// Weight of this reason.
    /// Represents how strongly this reason contributes to the total risk.
    /// </summary>
    public int Weight { get; }

    /// <summary>
    /// Creates a new decision reason.
    /// </summary>
    /// <param name="code">Reason identifier</param>
    /// <param name="message">Human-readable explanation</param>
    /// <param name="weight">Impact weight (default is 0)</param>
    public DecisionReason(IncidentCode code, string message, int weight = 0)
    {
        Code = code;
        Message = message;
        Weight = weight;
    }
}
