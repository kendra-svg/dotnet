using System;
//Console.WriteLine("Hello World"); //Top level statement needs to be commented so that Main method can work.
using System.Text;
StringBuilder builder = new();
builder.AppendLine("The following arguments are passed:");

foreach (var arg in args)
{
    builder.AppendLine($"Argument={arg}");
}

Console.WriteLine(builder.ToString());

return 0;

namespace MyNameSpace
{
    class MyClass
    {
    }

    struct MyStruct
    {
    }

    interface IMyInterface
    {
    }

    delegate int MyDelegate();

    enum MyEnum
    {
    }

    namespace MyNestedNamespace
    {
        struct MyStruct
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World from Program!");
            Console.WriteLine(args.Length);
        }
    }


}
