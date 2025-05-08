using System.Data.Common;
using System.Net.Http.Headers;

//public class Container
//{
//    //Initialize capacity field to a default value of 10:

//    private int _capacity = 10;
//}

//public class ContainerTwo
//{
//    private int _capacity;

//    public ContainerTwo(int capacity) => _capacity = capacity; //You can require callers to provide an initial value by defining a constructor that's responsible for setting that initial value 
//}

////Beginning C#12  you can define a primary constructor as part of the class declaration:
//public class ContainerThree(int capacity)
//{
//    private int _capcity = capacity;
//}

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

//public class Employee
//{

//}

//public class Manager : Employee
//{
//    //Employee fields, properties, methods and events are inherited

//    //New manager fields, properties methods and events go here...
//}

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

//public record Person(string FirstName, string LastName)
//{
//    public required string[] PhoneNumbers { get; init; }
//}

//public class Program
//{
//    public static void Main()
//    {
//        Person person1 = new("Nancy", "Drew") { PhoneNumbers = new string[1] };

//        Console.WriteLine(person1);
//        //output: Person { FirstName = Nancy, LastName = Davolio, PhoneNumbers = System.String[] }

//        Person person2 = person1 with { FirstName = "John" };
//        Console.WriteLine(person2);

//        //output: Person { FirstName = Nancy, LastName = Davolio, PhoneNumbers = System.String[]}

//        Console.WriteLine(person1 == person2); //output false

//        person2 = person1 with { };

//        Console.WriteLine(person1 == person2); //output True
//    }
//}


//To implement an interface member, the corresponding member of the implmenting class must be public, non static and have the same name and signature as the interface member.
//interface IEquatable<T>
//{
//    bool Equals(T obj);
//}

//public class Car : IEquatable<Car>
//{
//    public string? Make { get; set; }
//    public string? Model { get; set; }
//    public string? Year { get; set; }

//    //Implementation of IEquatable<T> interface

//    public bool Equals(Car? car)
//    {
//        return (this.Make, this.Model, this.Year) ==
//            (car?.Make, car?.Model, car?.Year);
//    }
//}

//POO gives us a modular, maintainable code full of building blocks we can easily reuse

//Generic classes

//public class GenericList<T>
//{
//    public void Add(T input) { }
//}

//class TestGenericList
//{
//    private class ExampleClass { }
//    static void Main()
//    {
//        //Declare a list of type int
//        GenericList<int> list1 = new GenericList<int>();
//        list1.Add(1);

//        //Declare a list of type string
//        GenericList<string> list2 = new GenericList<string>();
//        list2.Add("");

//        //Declare a list of type example class
//        GenericList<ExampleClass> list3 = new GenericList<ExampleClass>();
//        list3.Add(new ExampleClass());
//    }
//}

////Anonymous types 
//var v = new { Amount = 108, Message = "Hello" };

//Console.WriteLine(v.Amount + v.Message);


//Type parameter in angle brackets
//public class GenericList<T>
//{
//    //The nested class is also generic on T.
//    private class Node
//    {
//        //T used in non-generic constructor
//        public Node(T t)
//        {
//            next = null;
//            data = t;
//        }

//        private Node? next;
//        public Node? Next
//        {
//            get { return next; }
//            set { next = value; }
//        }

//        //T as private member data type
//        private T data;

//        //T as return type of property
//        public T Data
//        {
//            get { return data; }
//            set { data = value; }

//        }
//    }
//    private Node? head;

//    //constructor
//    public GenericList()
//    {
//        head = null;
//    }

//    //T as method parameter type
//    public void AddHead(T t)
//    {
//        Node n = new Node(t);
//        n.Next = head;
//        head = n;
//    }

//    public IEnumerator<T> GetEnumerator()
//    {
//        Node? current = head;

//        while (current != null)
//        {
//            yield return current.Data;
//            current = current.Next;
//        }
//    }
//}

//class TestGenericList
//{
//    static void Main()
//    {
//        GenericList<int> list = new GenericList<int>();

//        for (int x = 1; x < 11; x++)
//        {
//            list.AddHead(x);
//        }

//        foreach (int i in list)
//        {
//            Console.WriteLine(i + " ");
//        }
//        Console.WriteLine("\nDone");
//    }
//}

//var productInfo = new List<Product>()
//{
//   new Product 
//   {    Color = "Black",
//        Price = 1000
//   }
//};

//var productQuery =
//    from prod in productInfo
//    select new { prod.Color, prod.Price };

//foreach (var v in productQuery)
//{
//    Console.WriteLine("Color = {0}, Price={1}", v.Color, v.Price);

//}
//Console.ReadLine();

//var product = new Product();
//var bonus = new { note = "You won!" };
//var shipment = new { address = "Nowhere St.", product };
//var shipmentWithBonus = new { address = "Somewhere St.", product, bonus };

//var anonArray = new[] { new { name = "apple", diam = 4 }, new { name = "grape", diam = 1 }};

//var apple = new { Item = "apples", Price = 1.35 };
//var onSale = apple with { Price = 0.79 };
//Console.WriteLine(apple);
//Console.WriteLine(onSale);

//var v = new { Title = "Hello", Age = 24 };
//Console.WriteLine(v.ToString());

//class Product
//{
//    public string? Color { get; set; }
//    public decimal Price { get; set; }
//    public string? Name { get; set; }
//    public string? Category { get; set; }

//    public string? Size { get; set; }
//}


