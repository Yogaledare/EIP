namespace EIP._3._3_3._4_InheritencePolymorphism;

/// <summary>
/// Represents a Worm, inheriting from the Animal class, with an added property for the number of stripes.
/// </summary>
public class Worm : Animal {
    /// <summary>
    /// Gets or sets the number of stripes on the worm.
    /// </summary>
    public int NumStripes { get; set; }

    /// <summary>
    /// Initializes a new instance of the Worm class with specified age, weight, name, and number of stripes.
    /// </summary>
    /// <param name="age">The age of the worm.</param>
    /// <param name="weight">The weight of the worm.</param>
    /// <param name="name">The name of the worm.</param>
    /// <param name="numStripes">The number of stripes on the worm.</param>
    public Worm(int age, double weight, string name, int numStripes) : base(age, weight, name) {
        NumStripes = numStripes;
    }

    /// <summary>
    /// Produces the sound associated with the worm.
    /// </summary>
    public override void DoSound() {
        Console.WriteLine("Slither");
    }

    /// <summary>
    /// Returns a string that represents the current object's state, including the number of stripes on the worm.
    /// </summary>
    /// <returns>A string containing the name, age, weight, and number of stripes of the worm.</returns>
    public override string Stats() {
        var baseStats = base.Stats();
        return baseStats + $", NumStripes: {NumStripes}";
    }
}
