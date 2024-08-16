using System;
using CSharpPractice.Math;

namespace Variables
{

    class Program
    {
        static void Main(string[] args)
        {
            var axel = new Person();
            axel.FirstName = "Axel";
            axel.LastName = "Orozco";
            axel.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
        }
    }
}