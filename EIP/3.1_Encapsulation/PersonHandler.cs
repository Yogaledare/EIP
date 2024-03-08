namespace EIP._3._1_Encapsulation;

/// <summary>
/// Provides functionality to manage Person objects, including creation and property updates.
/// </summary>
public class PersonHandler {
    /// <summary>
    /// Creates a new Person object with the specified attributes.
    /// </summary>
    /// <param name="fname">First name of the person.</param>
    /// <param name="lname">Last name of the person.</param>
    /// <param name="age">Age of the person.</param>
    /// <param name="height">Height of the person.</param>
    /// <param name="weight">Weight of the person.</param>
    /// <returns>A new Person object.</returns>
    public Person CreatePerson(string fname, string lname, int age, double height, double weight) {
        return new Person(fname, lname) {
            Age = age,
            Height = height,
            Weight = weight
        };
    }

    /// <summary>
    /// Sets the age of the specified person.
    /// </summary>
    /// <param name="pers">The person whose age is to be set.</param>
    /// <param name="age">The new age.</param>
    public void SetAge(Person pers, int age) {
        pers.Age = age;
    }

    /// <summary>
    /// Sets the first name of the specified person.
    /// </summary>
    /// <param name="pers">The person whose first name is to be set.</param>
    /// <param name="fName">The new first name.</param>
    public void SetFName(Person pers, string fName) {
        pers.FName = fName;
    }

    /// <summary>
    /// Sets the last name of the specified person.
    /// </summary>
    /// <param name="pers">The person whose last name is to be set.</param>
    /// <param name="lName">The new last name.</param>
    public void SetLName(Person pers, string lName) {
        pers.LName = lName;
    }

    /// <summary>
    /// Sets the height of the specified person.
    /// </summary>
    /// <param name="pers">The person whose height is to be set.</param>
    /// <param name="height">The new height.</param>
    public void SetHeight(Person pers, double height) {
        pers.Height = height;
    }

    /// <summary>
    /// Sets the weight of the specified person.
    /// </summary>
    /// <param name="pers">The person whose weight is to be set.</param>
    /// <param name="weight">The new weight.</param>
    public void SetWeight(Person pers, double weight) {
        pers.Weight = weight;
    }

    /// <summary>
    /// Retrieves the age of the specified person.
    /// </summary>
    /// <param name="pers">The person whose age is to be retrieved.</param>
    /// <returns>The age of the person.</returns>
    public int GetAge(Person pers) {
        return pers.Age;
    }

    /// <summary>
    /// Retrieves the first name of the specified person.
    /// </summary>
    /// <param name="pers">The person whose first name is to be retrieved.</param>
    /// <returns>The first name of the person.</returns>
    public string GetFName(Person pers) {
        return pers.FName;
    }

    /// <summary>
    /// Retrieves the last name of the specified person.
    /// </summary>
    /// <param name="pers">The person whose last name is to be retrieved.</param>
    /// <returns>The last name of the person.</returns>
    public string GetLName(Person pers) {
        return pers.LName;
    }

    /// <summary>
    /// Retrieves the height of the specified person.
    /// </summary>
    /// <param name="pers">The person whose height is to be retrieved.</param>
    /// <returns>The height of the person.</returns>
    public double GetHeight(Person pers) {
        return pers.Height;
    }

    /// <summary>
    /// Retrieves the weight of the specified person.
    /// </summary>
    /// <param name="pers">The person whose weight is to be retrieved.</param>
    /// <returns>The weight of the person.</returns>
    public double GetWeight(Person pers) {
        return pers.Weight;
    }
}
