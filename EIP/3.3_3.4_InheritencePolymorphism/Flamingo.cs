namespace EIP._3._3_3._4_InheritencePolymorphism;

/// <summary>
/// Represents a Flamingo, inheriting from the Bird class with an added leg length property.
/// </summary>
public class Flamingo : Bird {
    /// <summary>
    /// Gets the leg length of the flamingo.
    /// </summary>
    public double LegLength { get; }

    /// <summary>
    /// Initializes a new instance of the Flamingo class with specified age, weight, name, color, and leg length.
    /// </summary>
    /// <param name="age">The age of the flamingo.</param>
    /// <param name="weight">The weight of the flamingo.</param>
    /// <param name="name">The name of the flamingo.</param>
    /// <param name="color">The color of the flamingo.</param>
    /// <param name="legLength">The leg length of the flamingo.</param>
    public Flamingo(int age, double weight, string name, string color, double legLength) : base(age, weight, name, color) {
        LegLength = legLength;
    }

    /// <summary>
    /// Returns a string that represents the current object's state, including the flamingo's leg length.
    /// </summary>
    /// <returns>A string containing the name, age, weight, color, and leg length of the flamingo.</returns>
    public override string Stats() {
        var baseStats = base.Stats();
        return baseStats + $", LegLength: {LegLength}";
    }
}
