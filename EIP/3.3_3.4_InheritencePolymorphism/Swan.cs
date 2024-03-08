namespace EIP._3._3_3._4_InheritencePolymorphism;

/// <summary>
/// Represents a Swan, inheriting from the Bird class, with an added property for neck length.
/// </summary>
public class Swan : Bird {
    /// <summary>
    /// Gets the neck length of the swan.
    /// </summary>
    public double NeckLength { get; }

    /// <summary>
    /// Initializes a new instance of the Swan class with specified age, weight, name, color, and neck length.
    /// </summary>
    /// <param name="age">The age of the swan.</param>
    /// <param name="weight">The weight of the swan.</param>
    /// <param name="name">The name of the swan.</param>
    /// <param name="color">The color of the swan.</param>
    /// <param name="neckLength">The neck length of the swan.</param>
    public Swan(int age, double weight, string name, string color, double neckLength) : base(age, weight, name, color) {
        NeckLength = neckLength;
    }

    /// <summary>
    /// Returns a string that represents the current object's state, including the swan's neck length.
    /// </summary>
    /// <returns>A string containing the name, age, weight, color, and neck length of the swan.</returns>
    public override string Stats() {
        var baseStats = base.Stats();
        return baseStats + $", NeckLength: {NeckLength}";
    }
}
