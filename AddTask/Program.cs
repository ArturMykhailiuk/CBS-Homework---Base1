using System;

namespace AddTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Adress adress = new Adress();
            adress.Index = "220007";
            adress.Country = "Ukraine";
            adress.City = "Kyiv";
            adress.Street = "A'intNoShit";
            adress.House = "187b";
            adress.Apartment = "00";

            Console.WriteLine(adress.Index);
            Console.WriteLine(adress.Country);
            Console.WriteLine(adress.City);
            Console.WriteLine(adress.Street);
            Console.WriteLine(adress.House);
            Console.WriteLine(adress.Apartment);
        }
    }
}
