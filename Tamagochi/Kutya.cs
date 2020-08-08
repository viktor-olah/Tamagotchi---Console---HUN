using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi
{
    class Kutya : Allat
    {

        #region Constructor
        public Kutya(string nev, byte kozerzet, byte ehsegiMutato, byte egeszsegMutato, byte szomjusag) : base(nev, kozerzet, ehsegiMutato, egeszsegMutato, szomjusag)
        {
        }
        #endregion

        #region Kutya functions & main functions
        public int Setaltatas()
        {
            return Kozerzet = (byte)(Kozerzet + 22);
        }

        public int Fulvakaras()
        {
            return Kozerzet = (byte)(Kozerzet + 12);
        }

        public override int Eves()
        {
            return EhsegiMutato = (byte)(EhsegiMutato + 20);

        }

        public override int Ivas()
        {
            return Szomjusag = (byte)(Szomjusag + 20);
        }

        public override int Jatek()
        {
            return Kozerzet = (byte)(Kozerzet + 15);
        }
        #endregion



        #region Main method
        public override void Eletvitel()
        {
            base.Eletvitel();
        }
        #endregion


        #region Strings override
        public override string AnimalStatus()
        {
            return $"A kutyád neve: {Nev}" + base.AnimalStatus();
        }

        public override string MainMenu()
        {
            return base.MainMenu() + $"s -- Sétáltatás , f -- Fülvakarás , \nx -- Sétáltatás + Játék , y -- Evés + ivás , z -- Játék + Fülvakarás";
        }
        #endregion

        #region AnimalGraph
        public override void AnimalASCIIGraph()
        {

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("  /^ ^\\");
            Console.WriteLine(" / 0 0 \\");
            Console.WriteLine(" V\\ Y /V");
            Console.WriteLine("  / - \\ ");
            Console.WriteLine(" /    | ");
            Console.WriteLine("V__) ||");
            Console.WriteLine(Environment.NewLine);
        }
        #endregion


    }
}
