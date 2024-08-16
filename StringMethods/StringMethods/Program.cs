using System;
using System.Text;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Axel Orozco ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("FisrtName: " + firstName);
            Console.WriteLine("lastName: " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("FisrtName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);

            Console.WriteLine(fullName.Replace("Axel","Roberto"));

            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            var str = "24";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.25f;
            Console.WriteLine(price.ToString("C0"));

            //------------------------------------------------------------//

            //Summarising Text
            var sentence = "This is goint to be a really really really really long text.";
            var summary = StringUtility.SummerizeText(sentence, 25);
            Console.WriteLine(summary);

            //------------------------------------------------------------//

            //StringBuilder
            var builder = new StringBuilder("Hello World");

            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+')
                .Remove(0, 10)
                .Insert(0, new string('-', 10));

            Console.WriteLine(builder);
            Console.WriteLine("Fist Character: ", builder[1]);

            //------------------------------------------------------------//

            //Procedural Programming
            Console.WriteLine("What's your name?: ");
            var name = Console.ReadLine();
            var reversed = ReverseName(name);
            Console.WriteLine("Reversed name: " + reversed);

        }

        public static string ReverseName(string name)
        {
            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];

            return new string(array);
        }
    }
}