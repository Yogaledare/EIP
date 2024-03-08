namespace EIP._3._3_3._4_InheritencePolymorphism;

/// <summary>
/// Represents a Hedgehog, inheriting from the Animal class and adding a property to indicate if it's curled up.
/// </summary>
public class Hedgehog : Animal {
    /// <summary>
    /// Gets or sets a value indicating whether the hedgehog is curled up.
    /// </summary>
    public bool IsCurledUp { get; }

    /// <summary>
    /// Initializes a new instance of the Hedgehog class with specified age, weight, name, and curled up state.
    /// </summary>
    /// <param name="age">The age of the hedgehog.</param>
    /// <param name="weight">The weight of the hedgehog.</param>
    /// <param name="name">The name of the hedgehog.</param>
    /// <param name="isCurledUp">Indicates if the hedgehog is curled up.</param>
    public Hedgehog(int age, double weight, string name, bool isCurledUp) : base(age, weight, name) {
        IsCurledUp = isCurledUp;
    }

    /// <summary>
    /// Produces the sound associated with the hedgehog.
    /// </summary>
    public override void DoSound() {
        Console.WriteLine("Sniff");
    }

    /// <summary>
    /// Returns a string that represents the current object's state, including if the hedgehog is curled up.
    /// </summary>
    /// <returns>A string containing the name, age, weight, and curled up state of the hedgehog.</returns>
    public override string Stats() {
        var baseStats = base.Stats();
        return baseStats + $", IsCurledUp: {IsCurledUp}";
    }
}
