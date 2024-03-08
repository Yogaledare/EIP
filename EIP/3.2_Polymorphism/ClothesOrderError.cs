namespace EIP._3._2_Polymorphism;

/// <summary>
/// Represents an error related to the incorrect order of putting on clothes.
/// </summary>
public class ClothesOrderError : UserError {
    /// <summary>
    /// Generates a user error message specific to clothing order errors.
    /// </summary>
    /// <returns>Error message as a string.</returns>
    public override string UEMessage() {
        return "You tried to put on your shoes before you put on your pants. This fired an error!";
    }
}
