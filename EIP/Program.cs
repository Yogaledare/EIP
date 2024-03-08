using EIP._3._1_Encapsulation;
using EIP._3._2_Polymorphism;
using EIP._3._3_3._4_InheritencePolymorphism;

namespace EIP;

/// <summary>
/// The main program class that demonstrates various concepts of OOP such as encapsulation, polymorphism, and inheritance.
/// </summary>
class Program {
    /// <summary>
    /// The main entry point for the demonstration.
    /// </summary>
    /// <param name="args">The command-line arguments.</param>
    static void Main(string[] args) {
        Part31();
        Console.WriteLine();
        Part32();
        Console.WriteLine();
        Part33_34();
    }


    /// <summary>
    /// Demonstrates encapsulation concepts by creating and manipulating Person objects.
    /// </summary>
    private static void Part31() {
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("Part 3.1: Encapsulation");
        Console.WriteLine();
        
        // // 3.1.1
        // try {
        //     var person = new Person("Erik", "Lindberg") {
        //         Age = 20,
        //         Height = 183,
        //         Weight = 78
        //     };
        //
        //     Console.WriteLine(
        //         $"FName: {person.FName},LName: {person.LName},Age: {person.Age},Height: {person.Height},Weight: {person.Weight}");
        // }
        // catch (ArgumentException e) {
        //     Console.WriteLine(e.Message);
        // }

        // 3.1.2 - 3.1.5
        try {
            var personHandler = new PersonHandler();
            var person1 = personHandler.CreatePerson("Anna", "Svensson", 25, 1.68, 58);
            var person2 = personHandler.CreatePerson("Lars", "Nilsson", 45, .175, 78);
            Console.WriteLine(personHandler.GetAge(person1));
            Console.WriteLine(personHandler.GetWeight(person2));

            // illegal age - will throw exception
            personHandler.SetAge(person1, -2);
        }
        catch (ArgumentException e) {
            Console.WriteLine(e.Message);
        }
    }


    /// <summary>
    /// Demonstrates polymorphism by executing methods on a list of UserError derived objects.
    /// </summary>
    private static void Part32() {
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("Part 3.2: Polymorphism");
        Console.WriteLine();
        
        // 3.2.1 - 3.2.7
        var errors = new List<UserError>() {
            new NumericInputError(),
            new TextInputError()
        };

        foreach (var error in errors) {
            Console.WriteLine(error.UEMessage());
        }

        Console.WriteLine();

        // 3.2.8 - 3.2.10
        var allErrors = new List<UserError>() {
            new NumericInputError(),
            new TextInputError(),
            new ClothesOrderError(),
            new DrivingError(),
            new SnakeError(),
        };

        foreach (var error in allErrors) {
            Console.WriteLine(error.UEMessage());
        }
    }


    /// <summary>
    /// Demonstrates inheritance and polymorphism by working with a diverse list of Animal objects and their methods.
    /// </summary>
    private static void Part33_34() {
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("Part 3.3 & 3.4: Inheritance & More Polymorphism");
        Console.WriteLine();
        
        // 3.3.13
        // F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, i vilken klass
        // bör vi lägga det?
        // Answer: In Bird - The base class parent for the birds. 

        // 3.3.14
        // F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
        // Answer: In Animal - The base class parent for all animals. 

        // 3.4.1 - 3.4.4
        var animals = new List<Animal> {
            new Horse(5, 500, "Starlight", true),
            new Dog(3, 30, "Buddy", "Labrador"),
            new Hedgehog(2, 1, "Spike", false),
            new Worm(1, 0.02, "Wiggles", 5),
            new Bird(4, 0.5, "Chirpy", "Yellow"),
            new Wolf(6, 80, "Fang", true),
            new Pelican(3, 15, "Gullet", "White", 1.5),
            new Flamingo(4, 8, "Pinky", "Pink", 90),
            new Swan(5, 12, "Grace", "White", 60),
            new WolfMan(30, 95, "Lupin", false)
        };


        // 3.4.5 - 3.4.7
        foreach (var animal in animals) {
            Console.WriteLine(animal.GetType().Name);
            animal.DoSound();
            if (animal is WolfMan wolfMan) {
                wolfMan.Talk();
            }

            Console.WriteLine();
        }

        // 3.4.8
        var dogs = new List<Dog>();
        dogs.Add(new Dog(4, 22, "Max", "Golden Retriever"));

        // 3.4.9
        // does not work: 
        // dogs.Add(new Horse(15, 135, "bella", true));
        
        // F: Försök att lägga till en häst i listan av hundar. Varför fungerar inte det?
        // Answer: An object of type Horse is not assignable to a parameter of type Dog, i.e., horses are not dogs.
        // Even though they share a common ancestor (Animal), there might be methods, fields, and properties unique to
        // dogs that we cannot call on a Horse. The type system prevents us from trying that.


        // 3.4.10 
        // F: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans?
        // Answer: The common ancestor parent class, Animal. We could also make an interface that we implement in both
        // Dog and Horse (or in Animal), and have the list be of that type. 

        
        // 3.4.11 - 3.4.12
        foreach (var animal in animals) {
            Console.WriteLine(animal.Stats());
        }
        
        // F: Förklara vad det är som händer.
        // This is inheritance polymorphism. We have declared to the type system that all classes deriving from Animal
        // will have an implementation of the Stats() method, either the base method or an overridden one. Therefore,
        // we can safely call it on an Animal object. The implementation of the method will be chosen at runtime
        // (dynamic binding), where methods more specific to the object's type will have priority.  

        Console.WriteLine();
        
        // 3.4.14 - 3.4.18
        foreach (var animal in animals) {
            if (animal is Dog dog) {
                Console.WriteLine(animal.Stats());
                // does not work: 
                // Console.WriteLine(animal.DoDogThings());
                
                // F: Kommer du åt den metoden från Animals listan? Varför inte?
                // No. Using an Animal object, we do not have access to the contract of the Dog class, since Dog is
                // downstream from Animal in the inheritance chain. We can not assume that an Animal has methods from a 
                // Dog class, since this implies we can assume all Animal objects have these methods. To use the Dog
                // methods, we have to cast the Animal object into a Dog object. If the cast is explicit, using
                // (Dog), this process might fail if the object is not a Dog. However, the cast above is safe since we 
                // only cast if the check passes (and is also atomic). 
                
                Console.WriteLine(dog.DoDogThings());
            }
        }
    }
}