using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Axel";
            var lastName = "Orozco";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0}{1}", firstName, lastName);

            var names = new string[3] { "axel", "juan", "cielo" };
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

            var text = @"Hi Axel
Look into the following paths
c:\folder1\folder2";
            Console.WriteLine(text);
        }
    }
}