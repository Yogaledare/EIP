namespace EIP._3._3_3._4_InheritencePolymorphism;

/// <summary>
/// Represents a Pelican, inheriting from the Bird class, with an added property for beak capacity.
/// </summary>
public class Pelican : Bird {
    /// <summary>
    /// Gets the beak capacity of the pelican.
    /// </summary>
    public double BeakCapacity { get; }

    /// <summary>
    /// Initializes a new instance of the Pelican class with specified age, weight, name, color, and beak capacity.
    /// </summary>
    /// <param name="age">The age of the pelican.</param>
    /// <param name="weight">The weight of the pelican.</param>
    /// <param name="name">The name of the pelican.</param>
    /// <param name="color">The color of the pelican.</param>
    /// <param name="beakCapacity">The beak capacity of the pelican.</param>
    public Pelican(int age, double weight, string name, string color, double beakCapacity) : base(age, weight, name, color) {
        BeakCapacity = beakCapacity;
    }

    /// <summary>
    /// Returns a string that represents the current object's state, including the pelican's beak capacity.
    /// </summary>
    /// <returns>A string containing the name, age, weight, color, and beak capacity of the pelican.</returns>
    public override string Stats() {
        var baseStats = base.Stats();
        return baseStats + $", BeakCapacity: {BeakCapacity}";
    }
}
