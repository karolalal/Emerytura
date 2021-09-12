using System;

namespace Emerytura
{
    class Program
    {
        const int WIEKEMERYTALNY = 65;
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swoje imię i nazwisko: ");
            string nazwa = Console.ReadLine();
            nazwa = nazwa.Trim().ToUpper();
            Console.WriteLine("Witaj {0}!", nazwa);

            Console.WriteLine("Podaj swój wiek: ");
            string wiekNapis = Console.ReadLine();

            int wiek = 0;
            try
            {
                wiek = int.Parse(wiekNapis);
            }
            catch(FormatException)
            {
                Console.WriteLine("Nie podałeś poprawnej liczby.\nKoniec aplikacji.");
                return;
            }
            catch(OverflowException)
            {
                Console.WriteLine("Podana wartość przekracza moje możliwości.\nKoniec aplikacji.");
                return;
            }

            Console.WriteLine($"Masz {wiek} lat.");
            if (wiek >= WIEKEMERYTALNY)
            {
                Console.WriteLine("Jesteś emerytem.");
            }
            else
            {
                Console.WriteLine($"Do emerytury zostało Ci {WIEKEMERYTALNY - wiek} lat.");
            }


        }
         
    }
}
