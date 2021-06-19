using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer1 = Addition(752, 939);
            int answer2 = Addition(955, 633);
            Console.WriteLine(answer1);
            Console.WriteLine(answer2);
            int answer3 = Multiply(25, 32);
            int answer4 = Multiply(45, 53);
            Console.WriteLine(answer3);
            Console.WriteLine(answer4);
            int answer5 = Subtraction(62, 34);
            int answer6 = Subtraction(54, 45);
            Console.WriteLine(answer5);
            Console.WriteLine(answer6);
            int answer7 = Division(24, 12);
            Console.WriteLine(answer7);
            int answer8 = Remainder(17, 4);
            Console.WriteLine(answer8);
            Console.WriteLine($"What is the radius of your circle");

            var a = 17;
            var b = 4;
            var radius = double.Parse(Console.ReadLine());
            var r = radius;
            var pi = Math.PI;
            var areaOfCircle = pi * (r * r);
            Console.WriteLine($"The area of a circle with radius of {r} is {areaOfCircle}");

            var div = a / b;
            var mod = a % b;
            Console.WriteLine($"{a}/{b} is {div} remainder {mod}");

            var i = 3;
            var j = 4;
            var k = ++i * j++;
            Console.WriteLine(k);


        }
        public static int Addition(int num1, int num2)
        {
            return num1 + num2;

        }
        public static int Multiply(int num3, int num4) 
        {
            return num3 * num4;
        }
        public static int Subtraction(int num5, int num6) 
        {
            return num5 - num6;

        
        }
        public static int Division(int num7, int num8) 
        {
            return num7 / num8;
        
        }
        public static int Remainder(int a, int b) 
        {
            return a % b;
        }

    }   
    
}

