namespace EIP._3._3_3._4_InheritencePolymorphism;

/// <summary>
/// Represents a WolfMan, combining traits from both Wolf and IPerson. Inherits from Wolf and implements IPerson.
/// </summary>
public class WolfMan : Wolf, IPerson {
    /// <summary>
    /// Initializes a new instance of the WolfMan class with specified age, weight, name, and alpha status.
    /// </summary>
    /// <param name="age">The age of the WolfMan.</param>
    /// <param name="weight">The weight of the WolfMan.</param>
    /// <param name="name">The name of the WolfMan.</param>
    /// <param name="isAlpha">Indicates if the WolfMan is an alpha.</param>
    public WolfMan(int age, double weight, string name, bool isAlpha) : base(age, weight, name, isAlpha) {
    }

    /// <summary>
    /// Allows the WolfMan to talk, fulfilling the IPerson interface contract.
    /// </summary>
    public void Talk() {
        Console.WriteLine("I am Wolfman");
    }
}
