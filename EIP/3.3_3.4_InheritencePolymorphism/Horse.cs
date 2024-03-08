namespace EIP._3._3_3._4_InheritencePolymorphism;

/// <summary>
/// Represents a Horse, inheriting from the Animal class, with an added property to indicate if it is white.
/// </summary>
public class Horse : Animal {
    /// <summary>
    /// Gets a value indicating whether the horse is white.
    /// </summary>
    public bool IsWhite { get; }

    /// <summary>
    /// Initializes a new instance of the Horse class with specified age, weight, name, and color status.
    /// </summary>
    /// <param name="age">The age of the horse.</param>
    /// <param name="weight">The weight of the horse.</param>
    /// <param name="name">The name of the horse.</param>
    /// <param name="isWhite">Indicates if the horse is white.</param>
    public Horse(int age, double weight, string name, bool isWhite) : base(age, weight, name) {
        IsWhite = isWhite;
    }

    /// <summary>
    /// Produces the sound associated with the horse.
    /// </summary>
    public override void DoSound() {
        Console.WriteLine("Neigh");
    }

    /// <summary>
    /// Returns a string that represents the current object's state, including if the horse is white.
    /// </summary>
    /// <returns>A string containing the name, age, weight, and color status of the horse.</returns>
    public override string Stats() {
        var baseStats = base.Stats();
        return baseStats + $", IsWhite: {IsWhite}";
    }
}
