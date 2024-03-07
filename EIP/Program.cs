namespace EIP;

class Program {
    static void Main(string[] args) {


        //
        // var person = new Person();
        //
        // var age = person.Age;
        //
        // Console.WriteLine(age);
        //
        // var fName = person.FName;
        //
        // Console.WriteLine(fName);


        // var persHandler = new PersonHandler();

        // var person = persHandler.CreatePerson(5, "maja", "gräddnos", 50.2, 10.5);



        // var age = persHandler.GetAge(person);
        // Console.WriteLine(age);
        
        // persHandler.SetAge(person, 10);
        // var age2 = persHandler.GetAge(person);

        // Console.WriteLine(age2);




        // var errorList = new List<UserError>() {
            // new NumericInputError(), 
            // new TextInputError()
        // };


        // foreach (var error in errorList) {
            // Console.WriteLine(error.UEMessage());
        // }


        // var errorList2 = new List<UserError>() {
            // new ClothesOrderError(),
            // new GearError(),
            // new SnakeError()
        // };
        //
        // foreach (var error in errorList2) {
        //     Console.WriteLine(error.UEMessage());
        // }
        //
        //
        //
        var animals = new List<Animal>(); 
        animals.Add(new Horse(12, 100, "börje", true));


        foreach (var animal in animals) {
            Console.WriteLine(animal.Stats());
        }

    }


   
    
    
    
    
}