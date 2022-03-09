using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Greet(string name)                      // method1
        {
            Console.WriteLine("Good Morning " + name);
        }

        static float Average(int a, int b, int c)             // method2
        {
            float sum = a + b + c;
            return sum / 3;
        }

        // method overloading - same method name but different parameter & perform action on parameter
        static float Average(int a, int b)        // method overloading
        {
            return (a + b) / 2;
        }

        static void Main(string[] args)
        {
            Greet("Vikas");            // calling method1
            Greet("Bholu");
            Console.WriteLine(Average(5, 7, 8));     // calling method2  
            Console.WriteLine(Average(1, 9, 11));
            float temp = Average(11, 88, 27);      //also we can assign value to a variable
            Console.WriteLine(temp);
            Console.WriteLine(Average(9, 3));
            Console.ReadLine();
        }
    }
}

