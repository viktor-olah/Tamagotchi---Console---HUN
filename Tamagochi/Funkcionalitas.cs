using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi
{
    static class Funkcionalitas
    {
        #region Kutya elemei
        public static void KutyaFunkciok(Kutya jelen)
        {
            Console.WriteLine($"{jelen.MainMenu()}");
            string valasztottMenu = Convert.ToString(Console.ReadKey().KeyChar.ToString()[0]);
            switch (valasztottMenu)
            {
                case "e":
                    jelen.Eves();
                    jelen.AnimalStatus();
                    Console.WriteLine(" -Megetetve");
                    break;
                case "i":
                    jelen.Ivas();
                    jelen.AnimalStatus();
                    Console.WriteLine(" -Megitatva");
                    break;
                case "j":
                    jelen.Jatek();
                    jelen.AnimalStatus();
                    Console.WriteLine(" -Játszva");
                    break;
                case "s":
                    jelen.Setaltatas();
                    jelen.AnimalStatus();
                    Console.WriteLine(" -Megsétaltatva");
                    break;
                case "f":
                    jelen.Fulvakaras();
                    jelen.AnimalStatus();
                    Console.WriteLine(" -Füle magvakarva");
                    break;
                case "x":
                    jelen.Setaltatas();
                    jelen.Jatek();
                    jelen.AnimalStatus();
                    Console.WriteLine(" -Sétáltatva + Játszva");
                    break;
                case "y":
                    jelen.Eves();
                    jelen.Ivas();
                    jelen.AnimalStatus();
                    Console.WriteLine(" -Megetetve + Itatva");
                    break;
                case "z":
                    jelen.Jatek();
                    jelen.Fulvakaras();
                    jelen.AnimalStatus();
                    Console.WriteLine(" -Játszva + Füle megvakarva");
                    break;
                default:
                    break;
            }
        }
        #endregion


        #region Macska elemei
        public static void MacskaFunkciok(Macska jelen)
        {
            Console.WriteLine($"{jelen.MainMenu()}");
            string valasztottMenu = Convert.ToString(Console.ReadKey().KeyChar.ToString()[0]);
            switch (valasztottMenu)
            {
                case "e":
                    jelen.Eves();
                    jelen.AnimalStatus();
                    Console.WriteLine(" -Megetetve");
                    break;
                case "i":
                    jelen.Ivas();
                    jelen.AnimalStatus();
                    Console.WriteLine(" -Megitatva");
                    break;
                case "j":
                    jelen.Jatek();
                    jelen.AnimalStatus();
                    Console.WriteLine(" -Játszva");
                    break;
                case "s":
                    jelen.Simogatas();
                    jelen.AnimalStatus();
                    Console.WriteLine(" -Megsimogatva");
                    break;
                case "k":
                    jelen.Szorzetapolas();
                    jelen.AnimalStatus();
                    Console.WriteLine(" -Szőrzete ápolva");
                    break;
                case "x":
                    jelen.Simogatas();
                    jelen.Jatek();
                    jelen.AnimalStatus();
                    Console.WriteLine(" -Megsimogatva + Játszva");
                    break;
                case "y":
                    jelen.Eves();
                    jelen.Ivas();
                    jelen.AnimalStatus();
                    Console.WriteLine(" -Megetetve + Itatva");
                    break;
                case "z":
                    jelen.Jatek();
                    jelen.Szorzetapolas();
                    jelen.AnimalStatus();
                    Console.WriteLine(" -Játszva + Szőrzete ápolva");
                    break;
                default:
                    break;
            }
        }
        #endregion

    }
}
