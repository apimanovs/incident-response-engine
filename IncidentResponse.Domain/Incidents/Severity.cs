namespace IncidentResponse.Domain.Incidents;

/// <summary>
/// Value Object representing incident severity.
/// 
/// This class ensures that severity is ALWAYS valid.
/// If an instance of Severity exists, its value is guaranteed
/// to be between 1 and 5.
/// 
/// Severity is immutable:
/// once created, it cannot be changed.
/// </summary>
public sealed class Severity
{
    /// <summary>
    /// Numeric severity value (1 = lowest, 5 = highest).
    /// </summary>
    public int Value { get; }

    /// <summary>
    /// This is the ONLY place where validation happens.
    /// If the value is invalid, the object will not be created.
    /// </summary>
    /// <param name="value">Severity level (must be between 1 and 5)</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when value is outside the allowed range.
    /// </exception>
    public Severity(int value)
    {
        if (value < 1 || value > 5)
        {
            throw new ArgumentOutOfRangeException(
                nameof(value),
                "Severity must be between 1 and 5."
            );
        }

        Value = value;
    }
}