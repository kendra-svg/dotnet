////Declare and initialize an array of integers
//int[] nums = [1, 2, 3, 4, 5];

////Access an instance property of System.Array
//int len = nums.Length;

//string x = "The answer is " + 5.ToString();
//Console.WriteLine(x);

//Type type = 12345.GetType();
//Console.WriteLine(type);

////
//List<string> stringList = new List<string>();
//stringList.Add("string example");

////stringList.Add(4); //compile time error for adding a type other than a string. Error: "cannot convert from 'int' to 'string'"

////Compile-time type and run-time type {
//string message = "This is a string of characters";

////different compile-time type:

//object anotherMessage = "This is a string of characters";
//IEnumerable<char> someCharacters = "abcdefgfgasjfshdfjksdhf";

using System.Collections.Concurrent;

public class Person()
{
    public string? Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age) : this()
    {
        this.Name = name;
        this.Age = age;
    }


}

class Program()
{
    public static void Main()
    {
        Person person1 = new Person("name", 0);
        Console.WriteLine("person1 Name = {0} Age = {1}", person1.Name, person1.Age);

        //Declare new person, assign person1 to it
        Person person2 = person1;

        //Change the name of person2, and person1 also changes.
        person2.Name = "Nombre";
        person2.Age = 22;

        Console.WriteLine("person2 Name = {0} Age = {1}", person2.Name, person2.Age);

        Console.WriteLine("person1 Name = {0} Age = {1}", person1.Name, person2.Age);


    }
}