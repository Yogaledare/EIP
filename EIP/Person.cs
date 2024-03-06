namespace EIP;

class Person {
    private int age;
    private string fName;
    private string lName;
    private double height;
    private double weight;


    public Person(string fName, string lName) {
        FName = fName;
        LName = lName; 
    }
    

    public int Age {
        get => age;
        set {
            var ageLower = 0;
            if (value < ageLower) {
                throw new ArgumentException($"Age must be {ageLower} years or higher.");
            }

            age = value;
        }
    }

    public string FName {
        get => fName;
        set {
            var fNameLower = 2;
            var fNameUpper = 10;
            if (string.IsNullOrWhiteSpace(FName)) {
                throw new ArgumentException("FName is mandatory.");
            }

            if (value.Length < fNameLower) {
                throw new ArgumentException($"FName cannot be shorter than {fNameLower} characters.");
            }

            if (value.Length > fNameUpper) {
                throw new ArgumentException($"FName cannot be longer than {fNameUpper} characters.");
            }

            fName = value;
        }
    }

    public string LName {
        get => lName;
        set {
            var lNameLower = 3;
            var lNameUpper = 15;

            if (string.IsNullOrWhiteSpace(LName)) {
                throw new ArgumentException("LName is mandatory.");
            }

            if (value.Length < lNameLower) {
                throw new ArgumentException($"LName cannot be shorter than {lNameLower} characters.");
            }

            if (value.Length > lNameUpper) {
                throw new ArgumentException($"LName cannot be longer than {lNameUpper} characters.");
            }

            lName = value;
        }
    }

    public double Height {
        get => height;
        set => height = value;
    }

    public double Weight {
        get => weight;
        set => weight = value;
    }
}
