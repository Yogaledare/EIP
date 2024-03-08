namespace EIP._3._1_Encapsulation;

/// <summary>
/// Represents a person with properties for age, first name, last name, height, and weight.
/// </summary>
public class Person {
    private int age;
    private string fName;
    private string lName;
    private double height;
    private double weight;

    /// <summary>
    /// Initializes a new instance of the Person class.
    /// </summary>
    /// <param name="fName">First name of the person.</param>
    /// <param name="lName">Last name of the person.</param>
    public Person(string fName, string lName) {
        FName = fName;
        LName = lName; 
    }

    /// <summary>
    /// Gets or sets the age of the person. Age must be 0 or higher.
    /// </summary>
    public int Age {
        get => age;
        set {
            if (value < 0) {
                throw new ArgumentException("Age must be 0 years or higher.");
            }
            age = value;
        }
    }

    /// <summary>
    /// Gets or sets the first name of the person. The name must be between 2 and 10 characters.
    /// </summary>
    public string FName {
        get => fName;
        set {
            if (string.IsNullOrWhiteSpace(value)) {
                throw new ArgumentException("FName is mandatory.");
            }
            if (value.Length < 2 || value.Length > 10) {
                throw new ArgumentException("FName must be between 2 and 10 characters.");
            }
            fName = value;
        }
    }

    /// <summary>
    /// Gets or sets the last name of the person. The name must be between 3 and 15 characters.
    /// </summary>
    public string LName {
        get => lName;
        set {
            if (string.IsNullOrWhiteSpace(value)) {
                throw new ArgumentException("LName is mandatory.");
            }
            if (value.Length < 3 || value.Length > 15) {
                throw new ArgumentException("LName must be between 3 and 15 characters.");
            }
            lName = value;
        }
    }

    /// <summary>
    /// Gets or sets the height of the person.
    /// </summary>
    public double Height {
        get => height;
        set => height = value;
    }

    /// <summary>
    /// Gets or sets the weight of the person.
    /// </summary>
    public double Weight {
        get => weight;
        set => weight = value;
    }
}
