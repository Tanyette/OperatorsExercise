using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var a = 17;
            var b = 4;

            //Addition
            var sum = a + b;
            Console.WriteLine($"Addition: {sum}");

            //Subtraction
            var diff = a - b;
            Console.WriteLine($"Subtraction: {diff}");

            //Multiplication
            var product = a * b;
            Console.WriteLine($"Multiplication: {product}");

            //Division
            var quotient = a / b;
            
            var remainder = a % b;
            Console.WriteLine($"The quotient is {quotient}with a remainder of {remainder}");
            Console.WriteLine();
            */

            Console.WriteLine("what is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());

            var circle = AreaOfCircle(radius);
            Console.WriteLine($"The area of your circle is {circle}");

        }

        public static double AreaOfCircle(double radius) 
        {
            return Math.PI * Math.Pow(radius, 2);
        } 
    }
}      
