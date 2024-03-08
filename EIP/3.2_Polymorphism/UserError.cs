namespace EIP._3._2_Polymorphism;

/// <summary>
/// Represents the base class for user errors. This abstract class defines a method for returning error messages.
/// </summary>
public abstract class UserError {
    /// <summary>
    /// Generates a user error message.
    /// </summary>
    /// <returns>A string representing the error message.</returns>
    public abstract string UEMessage();
}
