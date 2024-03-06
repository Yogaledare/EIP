namespace EIP;

class PersonHandler {
    public Person CreatePerson(int age, string fname, string lname, double height, double weight) {
        var person = new Person(fname, lname) {
            Age = age,
            // FName = fname,
            // LName = lname,
            Height = height,
            Weight = weight
        };

        return person;
    }

    public void SetAge(Person pers, int age) {
        pers.Age = age;
    }

    public void SetFName(Person pers, string fName) {
        pers.FName = fName;
    }

    public void SetLName(Person pers, string lName) {
        pers.LName = lName;
    }

    public void SetHeight(Person pers, double height) {
        pers.Height = height;
    }

    public void SetWeight(Person pers, double weight) {
        pers.Weight = weight;
    }

    public int GetAge(Person pers) {
        return pers.Age;
    }

    public string GetFName(Person pers) {
        return pers.FName;
    }

    public string GetLName(Person pers) {
        return pers.LName;
    }

    public double GetHeight(Person pers) {
        return pers.Height;
    }

    public double GetWeight(Person pers) {
        return pers.Weight;
    }
}