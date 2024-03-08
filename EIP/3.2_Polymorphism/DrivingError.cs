namespace EIP._3._2_Polymorphism;

/// <summary>
/// Represents an error when an unsafe driving action is attempted.
/// </summary>
public class DrivingError : UserError {
    /// <summary>
    /// Generates a user error message specific to driving errors.
    /// </summary>
    /// <returns>Error message as a string.</returns>
    public override string UEMessage() {
        return "You tried to put in the reverse while driving on the highway. This fired an error!";
    }
}
