namespace EIP._3._3_3._4_InheritencePolymorphism;

/// <summary>
/// Represents a Dog, inheriting from the Animal class and adding a breed property.
/// </summary>
public class Dog : Animal {
    /// <summary>
    /// Gets the breed of the dog.
    /// </summary>
    public string Breed { get; }

    /// <summary>
    /// Initializes a new instance of the Dog class with specified age, weight, name, and breed.
    /// </summary>
    /// <param name="age">The age of the dog.</param>
    /// <param name="weight">The weight of the dog.</param>
    /// <param name="name">The name of the dog.</param>
    /// <param name="breed">The breed of the dog.</param>
    public Dog(int age, double weight, string name, string breed) : base(age, weight, name) {
        Breed = breed;
    }

    /// <summary>
    /// Produces the sound associated with the dog.
    /// </summary>
    public override void DoSound() {
        Console.WriteLine("Woof");
    }

    /// <summary>
    /// Returns a string that represents the current object's state, including the dog's breed.
    /// </summary>
    /// <returns>A string containing the name, age, weight, and breed of the dog.</returns>
    public override string Stats() {
        var baseStats = base.Stats();
        return baseStats + $", Breed: {Breed}";
    }

    /// <summary>
    /// Represents actions or behaviors specific to the dog.
    /// </summary>
    /// <returns>A string indicating dog-specific actions.</returns>
    public string DoDogThings() {
        return "I am a dog";
    }
}