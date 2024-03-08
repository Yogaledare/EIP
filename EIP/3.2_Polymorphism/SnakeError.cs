namespace EIP._3._2_Polymorphism;

/// <summary>
/// Represents an error when attempting an unsafe interaction with a snake.
/// </summary>
public class SnakeError : UserError {
    /// <summary>
    /// Generates a user error message specific to snake interaction errors.
    /// </summary>
    /// <returns>Error message as a string.</returns>
    public override string UEMessage() {
        return "You tried to pet a snake. This fired an error!";
    }
}
