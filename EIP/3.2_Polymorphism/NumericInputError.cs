namespace EIP._3._2_Polymorphism;

/// <summary>
/// Represents an error when a numeric input is used in a text-only field.
/// </summary>
public class NumericInputError : UserError {
    /// <summary>
    /// Generates a user error message specific to numeric input errors.
    /// </summary>
    /// <returns>Error message as a string.</returns>
    public override string UEMessage() {
        return "You tried to use a numeric input in a text only field. This fired an error!";
    }
}
