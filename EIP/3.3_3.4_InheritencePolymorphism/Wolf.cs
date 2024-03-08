namespace EIP._3._3_3._4_InheritencePolymorphism;

/// <summary>
/// Represents a Wolf, inheriting from the Animal class, with an added property to indicate if it is an alpha.
/// </summary>
public class Wolf : Animal {
    /// <summary>
    /// Gets or sets a value indicating whether the wolf is an alpha within its pack.
    /// </summary>
    public bool IsAlpha { get; set; }

    /// <summary>
    /// Initializes a new instance of the Wolf class with specified age, weight, name, and alpha status.
    /// </summary>
    /// <param name="age">The age of the wolf.</param>
    /// <param name="weight">The weight of the wolf.</param>
    /// <param name="name">The name of the wolf.</param>
    /// <param name="isAlpha">Indicates if the wolf is an alpha.</param>
    public Wolf(int age, double weight, string name, bool isAlpha) : base(age, weight, name) {
        IsAlpha = isAlpha;
    }

    /// <summary>
    /// Produces the sound associated with the wolf.
    /// </summary>
    public override void DoSound() {
        Console.WriteLine("Howl");
    }

    /// <summary>
    /// Returns a string that represents the current object's state, including the alpha status of the wolf.
    /// </summary>
    /// <returns>A string containing the name, age, weight, and alpha status of the wolf.</returns>
    public override string Stats() {
        var baseStats = base.Stats();
        return baseStats + $", IsAlpha: {IsAlpha}";
    }
}
