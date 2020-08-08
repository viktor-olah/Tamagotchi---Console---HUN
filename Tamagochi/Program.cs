using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tamagochi
{
    class Program
    {

        static void Main(string[] args)
        {
            #region Start message
            Console.WriteLine("Üdvözlöm a tamagochi alkalmazásban!");
            Console.WriteLine("Kérem válasszon egy számot [] a billentyűzet segítségével, amelyik álattal játszani szeretne! \n");

            Console.WriteLine("[1] -- Kutya");
            Console.WriteLine("[2] -- Macska");
            #endregion

            char valasztottAllat = Console.ReadKey(true).KeyChar.ToString()[0];
            switch (valasztottAllat)
            {
                #region Kutya (Case 1)
                case '1':
                    Console.Clear();
                    Console.WriteLine("Kérem nevezze el a kutyáját: ");

                    // Új példány User név megadással + max statokkal 
                    Kutya newdog = new Kutya(Console.ReadLine(), 100, 100, 100, 100);
                    //

                    //Kezdőképernyő ,állat megnevezése után
                    Console.Clear();
                    newdog.AnimalASCIIGraph();
                    Console.WriteLine($"{newdog.AnimalStatus()}");
                    Console.WriteLine("\nNagyon fontos ,hogy figyelj az állatod állapotára és időben cselekedj a menü segítségével!");
                    Thread.Sleep(8000);
                    //

                    while (newdog.EgeszsegMutato > 0)
                    {
                        // Időzítés "process lasítással" - timer helyett. Stat változás sebességéért felel.
                        Thread.Sleep(2000);
                        //

                        newdog.Eletvitel();
                        Console.WriteLine($"{Environment.NewLine} A Menü megnyitásához kérem nyomja meg az [m] betűt.");

                        while (Console.KeyAvailable && (Console.ReadKey().KeyChar.ToString()[0] == 'm'))
                        {
                            Funkcionalitas.KutyaFunkciok(newdog);
                            break;

                        }
                    }
                    Console.Clear();
                    Console.WriteLine("Sajnos nem voltál elég figyelmes!");
                    break;
                #endregion

                #region Macska (Case 2)
                case '2':
                    Console.Clear();
                    Console.WriteLine("Kérem nevezze el a macskáját: ");

                    // Új példány User név megadással + max statokkal 
                    Macska newcat = new Macska(Console.ReadLine(), 100, 100, 100, 100);
                    //

                    //Kezdőképernyő ,állat megnevezése után
                    Console.Clear();
                    newcat.AnimalASCIIGraph();
                    Console.WriteLine($"{newcat.AnimalStatus()}");
                    Console.WriteLine("\nNagyon fontos ,hogy figyelj az állatod állapotára és időben cselekedj a menü segítségével!");
                    Thread.Sleep(8000);
                    //

                    while (newcat.EgeszsegMutato > 0)
                    {
                        // Időzítés "process lasítással" - timer helyett. Stat változás sebességéért felel.
                        Thread.Sleep(2000);
                        //

                        newcat.Eletvitel();
                        Console.WriteLine($"{Environment.NewLine} A Menü megnyitásához kérem nyomja meg az [m] betűt.");

                        while (Console.KeyAvailable && (Console.ReadKey().KeyChar.ToString()[0] == 'm'))
                        {
                            Funkcionalitas.MacskaFunkciok(newcat);
                            break;
                        }
                    }
                    Console.Clear();
                    Console.WriteLine("Sajnos nem voltál elég figyelmes!");
                    break;

                #endregion

                default:
                    Console.WriteLine("Sajnalom ilyen opció nincs kérem próbálja meg ismét!");
                    break;

            }
            Console.ReadKey();
        }
    }
}
