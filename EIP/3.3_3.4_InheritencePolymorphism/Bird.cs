namespace EIP._3._3_3._4_InheritencePolymorphism;

/// <summary>
/// Represents a Bird, inheriting from the Animal class and adding a color property.
/// </summary>
public class Bird : Animal {
    /// <summary>
    /// Gets the color of the bird.
    /// </summary>
    public string Color { get; }

    /// <summary>
    /// Initializes a new instance of the Bird class with specified age, weight, name, and color.
    /// </summary>
    /// <param name="age">The age of the bird.</param>
    /// <param name="weight">The weight of the bird.</param>
    /// <param name="name">The name of the bird.</param>
    /// <param name="color">The color of the bird.</param>
    public Bird(int age, double weight, string name, string color) : base(age, weight, name) {
        Color = color;
    }

    /// <summary>
    /// Produces the sound associated with the bird, overriding the abstract method in the Animal class.
    /// </summary>
    public override void DoSound() {
        Console.WriteLine("Chirp");
    }

    /// <summary>
    /// Returns a string that represents the current object's state, including the bird's color,
    /// by extending the base class Stats method.
    /// </summary>
    /// <returns>A string containing the name, age, weight, and color of the bird.</returns>
    public override string Stats() {
        var baseStats = base.Stats();
        return baseStats + $", Color: {Color}";
    }
}
