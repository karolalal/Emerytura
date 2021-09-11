using System;

namespace Emerytura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swoje imię i nazwisko: ");
            string nazwa = Console.ReadLine();
            Console.WriteLine("Witaj {0}!", nazwa);

            Console.WriteLine("Podaj swój wiek: ");
            string wiekNapis = Console.ReadLine();
            int wiek = int.Parse(wiekNapis);
            Console.WriteLine($"Masz {wiek} lat.");
            if (wiek >= 67)
            {
                Console.WriteLine("Jesteś emerytem.");
            }
            else
            {
                Console.WriteLine($"Do emerytury zostało Ci {67 - wiek} lat.");
            }


        }
    }
}
