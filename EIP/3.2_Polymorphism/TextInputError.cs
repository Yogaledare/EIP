namespace EIP._3._2_Polymorphism;

/// <summary>
/// Represents an error when a text input is used in a numeric-only field.
/// </summary>
public class TextInputError : UserError {
    /// <summary>
    /// Generates a user error message specific to text input errors.
    /// </summary>
    /// <returns>Error message as a string.</returns>
    public override string UEMessage() {
        return "You tried to use a text input in a numeric only field. This fired an error!";
    }
}
