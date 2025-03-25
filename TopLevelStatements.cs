//Top level statements must precede namespaces and types

using System.Threading.Channels;

MyClass.TestMethod();
MyNamespace.MyClass.MyMethod();

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

public class MyClass
{
    public static void TestMethod()
    {
        Console.WriteLine("Hello World!");
    }


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


