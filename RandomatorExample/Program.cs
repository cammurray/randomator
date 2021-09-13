using System;
using Randomator;

namespace RandomatorExample
{
    class Program
    {
        static void Main(string[] args)
        {

            /*

            Random Person

            */

            Console.WriteLine($"\n Random people \n");

            for(var x = 0; x <= 5; x++) OutputRandomPerson();

            /*

            Random Location

            */

            Console.WriteLine($"\n Random locations \n");

            for(var x = 0; x <= 1; x++) OutputRandomLocation();

            /*

            Random phone numbers from anywhere

            */

            Console.WriteLine($"\n Random phone numbers from anywhere! \n");

            for(var x = 0; x <= 5; x++)
            {
                Console.WriteLine(new RandomPhone(RandomPhoneType.Land).ToString());
            }

            /*

            Random mobile numbers in australia

            */

            Console.WriteLine($"\n Random mobile numbers from Australia! \n");

            for(var x = 0; x <= 5; x++)
            {
                Console.WriteLine(new RandomPhone(RandomPhoneType.Mobile, "Australia").ToString());
            }

            /*

            Random sentences

            */

            Console.WriteLine($"\n Random sentences using markov chain! \n");

            RandomSentence RandomSentence = new RandomSentence();

            for(var x = 0; x <= 5; x++)
            {
                Console.WriteLine(RandomSentence.Generate());
            }

        }

        static void OutputRandomPerson()
        {
            RandomPerson RandomPerson = new RandomPerson();

            Console.WriteLine($"Firstname: {RandomPerson.Firstname}");
            Console.WriteLine($"Lastname: {RandomPerson.Lastname}");
            Console.WriteLine($"Mobile: {RandomPerson.PhoneMobile.ToString()}");
            Console.WriteLine($"Home Address: {RandomPerson.LocationHome.ToString()}");
            Console.WriteLine($"Home Phone: {RandomPerson.PhoneHome.ToString()}");
            Console.WriteLine($"Work Address: {RandomPerson.LocationWork.ToString()}");
            Console.WriteLine($"Work Phone: {RandomPerson.PhoneWork.ToString()}");

            Console.WriteLine("\n");

        }

        static void OutputRandomLocation()
        {
            RandomLocation RandomLocation = new RandomLocation();

            Console.WriteLine($"City: {RandomLocation.City}");
            Console.WriteLine($"Country: {RandomLocation.Country}");
            Console.WriteLine($"Address: {RandomLocation.ToString()}");

            Console.WriteLine("\n");
        }
    }
}
