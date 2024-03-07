using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace EIP;

public abstract class Animal {
    public int Age { get; set; }
    public double Weight { get; set; }
    public string Name { get; set; }


    public abstract void DoSound();


    public Animal(int age, double weight, string name) {
        Age = age;
        Weight = weight;
        Name = name;
    }


    public virtual string Stats() {
        return $"Age: {Age}, Weight: {Weight}, Name: {Name}"; 
    }
    
    

    public string Stats2() {

        StringBuilder stringBuilder = new StringBuilder();
        var properties = this.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

        foreach (var propertyInfo in properties) {
            var name = propertyInfo.Name; 
            var value = propertyInfo.GetValue(this);
            stringBuilder.Append($"{name}: {value}, "); 
        }

        return stringBuilder.ToString(); 
    }
    
}

public class Horse : Animal {
    public bool IsWhite { get; set; }

    public Horse(int age, double weight, string name, bool isWhite) : base(age, weight, name) {
        IsWhite = isWhite;
    }

    public override void DoSound() {
        Console.WriteLine("Neigh");
    }

    public override string Stats() {
        var baseStats = base.Stats();
        return baseStats + $", IsWhite: {IsWhite}"; 
    }
}

public class Dog : Animal {
    public string Breed { get; set; }


    public Dog(int age, double weight, string name, string breed) : base(age, weight, name) {
        Breed = breed;
    }

    public override void DoSound() {
        Console.WriteLine("Woof");
    }

    public override string Stats() {
        var baseStats = base.Stats();
        return baseStats + $", Breed: {Breed}"; 
    }
}

public class Hedgehog : Animal {
    public bool IsCurledUp { get; set; }

    public Hedgehog(int age, double weight, string name, bool isCurledUp) : base(age, weight, name) {
        IsCurledUp = isCurledUp;
    }

    public override void DoSound() {
        Console.WriteLine("Sniff");
    }
    
    public override string Stats() {
        var baseStats = base.Stats();
        return baseStats + $", IsCurledUp: {IsCurledUp}"; 
    }
}

public class Worm : Animal {
    public int NumStripes { get; set; }

    public Worm(int age, double weight, string name, int numStripes) : base(age, weight, name) {
        NumStripes = numStripes;
    }

    public override void DoSound() {
        Console.WriteLine("Slither");
    }
    
    public override string Stats() {
        var baseStats = base.Stats();
        return baseStats + $", NumStripes: {NumStripes}"; 
    }
    
}

public class Bird : Animal {
    public string Color { get; set; }

    public Bird(int age, double weight, string name, string color) : base(age, weight, name) {
        Color = color;
    }

    public override void DoSound() {
        Console.WriteLine("Chirp");
    }
    
    public override string Stats() {
        var baseStats = base.Stats();
        return baseStats + $", Color: {Color}"; 
    }
    
}

public class Wolf : Animal {
    public bool IsAlpha { get; set; }

    public Wolf(int age, double weight, string name) : base(age, weight, name) {
    }

    public override void DoSound() {
        Console.WriteLine("Howl");
    }
    
    public override string Stats() {
        var baseStats = base.Stats();
        return baseStats + $", IsAlpha: {IsAlpha}"; 
    }
    
}

public class Pelican : Bird {
    public double BeakCapacity { get; }

    public Pelican(int age, double weight, string name, string color, double beakCapacity) : base(age, weight, name,
        color) {
        BeakCapacity = beakCapacity;
    }
    
    public override string Stats() {
        var baseStats = base.Stats();
        return baseStats + $", BeakCapacity: {BeakCapacity}"; 
    }
}

public class Flamingo : Bird {
    public double LegLength { get; }

    public Flamingo(int age, double weight, string name, string color, double legLength) : base(age, weight, name,
        color) {
        LegLength = legLength;
    }
    
    public override string Stats() {
        var baseStats = base.Stats();
        return baseStats + $", LegLength: {LegLength}"; 
    }
}

public class Swan : Bird {
    public double NeckLength { get; }

    public Swan(int age, double weight, string name, string color, double neckLength) : base(age, weight, name, color) {
        NeckLength = neckLength;
    }
    
    public override string Stats() {
        var baseStats = base.Stats();
        return baseStats + $", NeckLength: {NeckLength}"; 
    }
}

public interface IPerson {
    void Talk(); 
}


public class WolfMan : Wolf, IPerson {
    public WolfMan(int age, double weight, string name) : base(age, weight, name) {
    }

    public void Talk() {
        Console.WriteLine("I am Wolfman");
    }
}

// 13. F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, i vilken klass bör vi lägga det?

// svar: i fågel-basklassen - Bird

// 14. F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?

// svar: i djur-basklassen - Animal