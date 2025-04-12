public class Container
{
    //Initialize capacity field to a default value of 10:

    private int _capacity = 10;
}

public class ContainerTwo
{
    private int _capacity;

    public ContainerTwo(int capacity) => _capacity = capacity; //You can require callers to provide an initial value by defining a constructor that's responsible for setting that initial value 
}

//Beginning C#12  you can define a primary constructor as part of the class declaration:
public class ContainerThree(int capacity)
{
    private int _capcity = capacity;
}

//Adding parameters to the class name defines the primary constructor. Those parameters are available in the class body, which includes its members. You can use them to initializa fields or anywhere else where they're needed.

//You can also use the required modifier on a property and allow callers to use an object initializer to set the initial value of the property:

//public class Person
//{
//    public required string LastName { get; set; }
//    public required string FirstName { get; set; }


//}

//The addition of the required keyword mandates that callers must set those properties as part of a *new* expression

//var p1 = new Person(); //this will not compile as the required properties are not set

//public class Program
//{


//    public static void Main(string[] args)
//    {
//        PersonObject();
//    }

//    public static Person PersonObject()
//    {
//        var p2 = new Person() { FirstName = "Grace", LastName = "Hopper" };
//        Console.WriteLine(p2);
//        return p2;
//    }

//}

public class Employee
{

}

public class Manager : Employee
{
    //Employee fields, properties, methods and events are inherited

    //New manager fields, properties methods and events go here...
}

//An abstract class contains abstract methods that have a signature definition but no implementation

//A record is class or struct that provides special syntax and behavior for working with data models

//A record's ToString method creates a formatted string that shows an object's type name and the names and values of all its public properties

//A record can inherit from another record. A record can't inherit from a class, and a class can't inherit from a record. 

//public record Persona(string firstName, string lastName)
//{
//    public static class Program
//    {
//        public static void Main()
//        {
//            Persona persona = new("Nancy", "Drew");

//            Console.WriteLine(persona);
//        }
//    }
//}

//public record NewPerson(string FirstName, string LastName, string[] PhoneNumbers);

//public class Program
//{
//    public static void Main()
//    {
//        var phoneNumbers = new string[2];
//        NewPerson newPerson1 = new NewPerson("Nancy", "Drew", phoneNumbers);
//        NewPerson newPerson2 = new NewPerson("Nancy", "Drew", phoneNumbers);
//        Console.WriteLine(newPerson1 == newPerson2); //true

//        newPerson1.PhoneNumbers[0] = "123-4567";
//        Console.WriteLine(newPerson1 == newPerson2); //true

//        Console.WriteLine(ReferenceEquals(newPerson1, newPerson2)); //false
//    }
//}

//The following example demonstrates use of a with expression to copy an immutable object and change one of the properties

public record Person(string FirstName, string LastName)
{
    public required string[] PhoneNumbers { get; init; }
}

public class Program
{
    public static void Main()
    {
        Person person1 = new("Nancy", "Drew") { PhoneNumbers = new string[1] };

        Console.WriteLine(person1);
        //output: Person { FirstName = Nancy, LastName = Davolio, PhoneNumbers = System.String[] }

        Person person2 = person1 with { FirstName = "John" };
        Console.WriteLine(person2);

        //output: Person { FirstName = Nancy, LastName = Davolio, PhoneNumbers = System.String[]}

        Console.WriteLine(person1 == person2); //output false

        person2 = person1 with { };

        Console.WriteLine(person1 == person2); //output True
    }
}


//To implement an interface member, the corresponding member of the implmenting class must be public, non static and have the same name and signature as the interface member.
interface IEquatable<T>
{
    bool Equals(T obj);
}

public class Car : IEquatable<Car>
{
    public string? Make { get; set; }
    public string? Model { get; set; }
    public string? Year { get; set; }

    //Implementation of IEquatable<T> interface

    public bool Equals(Car? car)
    {
        return (this.Make, this.Model, this.Year) ==
            (car?.Make, car?.Model, car?.Year);
    }
}

//POO gives us a modular, maintainable code full of building blocks we can easily reuse