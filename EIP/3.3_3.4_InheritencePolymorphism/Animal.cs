namespace EIP._3._3_3._4_InheritencePolymorphism;

/// <summary>
/// Represents the base class for all animal types. 
/// This abstract class provides common properties and methods that all animals share.
/// </summary>
public abstract class Animal {
    
    /// <summary>
    /// Gets the age of the animal.
    /// </summary>
    public int Age { get; }
    
    /// <summary>
    /// Gets the weight of the animal.
    /// </summary>
    public double Weight { get; }
    
    /// <summary>
    /// Gets the name of the animal.
    /// </summary>
    public string Name { get; }


    /// <summary>
    /// Initializes a new instance of the <see cref="Animal"/> class with specified age, weight, and name.
    /// </summary>
    /// <param name="age">The age of the animal.</param>
    /// <param name="weight">The weight of the animal.</param>
    /// <param name="name">The name of the animal.</param>
    public Animal(int age, double weight, string name) {
        Age = age;
        Weight = weight;
        Name = name;
    }


    /// <summary>
    /// When implemented in a derived class, produces the sound associated with the animal.
    /// </summary>
    public abstract void DoSound();


    /// <summary>
    /// Returns a string that represents the current object's state.
    /// </summary>
    /// <returns>A string containing the name, age, and weight of the animal.</returns>
    public virtual string Stats() {
        return $"Age: {Age}, Weight: {Weight}, Name: {Name}";
    }
}

