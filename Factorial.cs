﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection.Emit;
//using System.Text;
//using System.Threading.Tasks;

//namespace newdotnet
//{
//    public class Functions
//    {
//        public static long Factorial(int n)
//        {
//            if ((n < 0) || (n > 20))
//            {
//                return -1;
//            }
//            long tempResult = 1;

//            for (int i = 1; i <= n; i++)
//            {
//                tempResult *= i;
//            }
//            return tempResult;
//        }
//    }

//    class MainClass
//    {
//        static int Main(string[] args)
//        {
//            if (args.Length == 0)
//            {
//                Console.WriteLine("Please enter a numeric argument.");
//                Console.WriteLine("Usage: Factorial <num>");
//                return 1;
//            }

//            int num;
//            bool test = int.TryParse(args[0], out num);
//            if (!test)
//            {
//                Console.WriteLine("Please enter a numeric argument.");
//                Console.WriteLine("Usage: Factorial <num>");
//                return 1;
//            }
//            long result = Functions.Factorial(num);
//            if (result == -1)
//            {
//                Console.WriteLine("Input must be >= 0 and <= 20.");

//            }
//            else
//            {
//                Console.WriteLine($"The Factorial of {num} is {result}.");
                
//            }
//            return 0;

            
//        }
        
//    }
//}
