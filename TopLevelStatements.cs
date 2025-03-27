//Top level statements must precede namespaces and types

using System.Runtime.CompilerServices;
using System.Threading.Channels;

MyClass.TestMethod();
MyNamespace.MyClass.MyMethod();
//MyClass.GetName(1); //If I leave it like this, I will a get "An object reference is required for the non-static field, method, or property 'MyClass.GetName(int)'", meaning that I have to instantiate it. I'll do it below:

MyClass myInstance = new MyClass();
myInstance.GetName(1);

//With those 2 lines of code above, now the code compiles.

if (args.Length > 0)
{
    foreach (var arg in args)
    {
        Console.WriteLine($"Argument={arg}");
    }
}
else
{
    Console.WriteLine("No arguments");
}

Console.WriteLine("Hello");
await Task.Delay(5000);
Console.WriteLine("World!");

string? s = Console.ReadLine();

int returnValue = int.Parse(s ?? "-1");
return returnValue;

//int a = 5;
//int b = a + 2;

//bool test = true;

//int c = a + test;

//above was expected to not compile due to Error: Operator '+' cannot be applied to operands of type 'int' and 'bool'

//Declaration only
float temperature;
string name;
MyClass myClass;

//Declaration with initializers (four examples):
char firstLetter = 'C';
var limit = 3;
int[] source = [1, 2, 3, 4, 5];
var query = from item in source
            where item <= limit
            select item;

//constant field on type byte
byte b = byte.MaxValue;

//you declare and assign values to them as if theyre simple non-aggregate types

byte num = 0xA;
int i = 5;
char c = 'Z';

//Value types are sealed. You cant derive a type from any value type

//You use the struct keyword to create your own custom value types. Typically, a struct is used as a container for a small set of related variables, as shown in the following example:

public struct Coords
{
    public int x, y;

    public Coords(int p1, int p2)
    {
        x = p1;
        y = p2;
    }
}


public class MyClass
{
    public static void TestMethod()
    {
        Console.WriteLine("Hello World!");
    }

    public string GetName(int ID)
    {
        if (ID < names.Length)
        {
            Console.WriteLine($"{names[ID]}");
            return names[ID];
        }

        else
        {
            Console.WriteLine($"Printing: '{String.Empty}' ");
            return String.Empty;
        }

    }
    private string[] names = ["Spencer", "Sally", "Doug"];
}

namespace MyNamespace
{
    class MyClass
    {
        public static void MyMethod()
        {
            Console.WriteLine("Hello World from MyNamespace.MyClass.MyMethod!");
        }
    }
}


