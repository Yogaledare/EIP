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


        var persHandler = new PersonHandler();

        var person = persHandler.CreatePerson(5, "maja", "gräddnos", 50.2, 10.5);



        var age = persHandler.GetAge(person);
        Console.WriteLine(age);
        
        persHandler.SetAge(person, 10);
        var age2 = persHandler.GetAge(person);

        Console.WriteLine(age2);
        





    }


   
    
    
    
    
}