﻿public class Container
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

public class Person
{
    public required string LastName { get; set; }
    public required string FirstName { get; set; }


}

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

public record Persona(string firstName, string lastName)
{
    public static class Program
    {
        public static void Main()
        {
            Persona persona = new("Nancy", "Drew");

            Console.WriteLine(persona);
        }
    }
}

