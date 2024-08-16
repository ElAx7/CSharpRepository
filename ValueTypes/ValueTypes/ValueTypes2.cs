using System;

namespace ValueTypes
{
	public class Person
	{
		public int Age;
	}

	class ValueTypes

	{
		static void Main(string[] args)
		{
            var number = 1;
            Increment(number);
            Console.WriteLine(number);

            var person = new Person() { Age = 20 };
            MakeOld(person);
            Console.WriteLine(person.Age);
		}

        //Method 1 no regresan ningun valor
        public static void Increment(int number)
        {
            number += 10;
        }

        //Method 2 no regresan ningun valor
        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}

