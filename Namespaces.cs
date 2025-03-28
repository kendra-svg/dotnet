using newdotnet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newdotnet
{

    class Program
    {
        public static void Main(string[] args)
        {
            Namespaces.SampleMethod();
            AnotherSampleClass.AnotherSampleMethod();
        }
    }
    class Namespaces
    {
        public static void SampleMethod()
        {
            Console.WriteLine("Sample method inside Namespaces");
        }
    }

    class AnotherSampleClass
    {
        public static void AnotherSampleMethod()
        {
            Console.WriteLine("SampleMethod inside Namespaces");
        }
    }
}


