using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi
{
    class Macska : Allat
    {

        #region Constructor
        public Macska(string nev, byte kozerzet, byte ehsegiMutato, byte egeszsegMutato, byte szomjusag) : base(nev, kozerzet, ehsegiMutato, egeszsegMutato, szomjusag)
        {
        }
        #endregion

        #region Macska functions & main functions
        public int Simogatas()
        {
            return Kozerzet = (byte)(Kozerzet + 22);
        }

        public int Szorzetapolas()
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
            return $"A macskád neve: {Nev}" + base.AnimalStatus();
        }

        public override string MainMenu()
        {
            return base.MainMenu() + $"s -- Simogatás , k -- Szőrzetápolás , \nx -- Simogatás + Játék , y -- Evés + ivás , z -- Játék + Szőrzetápolás";
        }
        #endregion

        #region AnimalGraph
        public override void AnimalASCIIGraph()
        {
            Console.Clear();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("  /\\_/\\ ");
            Console.WriteLine(" ( o.o )");
            Console.WriteLine("  > ^ <");
            Console.WriteLine("  / - \\ ");
            Console.WriteLine(" /    | ");
            Console.WriteLine("V__) ||");
        }
        #endregion


    }
}
