using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi
{
    abstract class Allat
    {

        string nev;
        byte kozerzet;
        byte ehsegiMutato;
        byte egeszsegMutato;
        byte szomjusag;

        //Properties
        public string Nev { get => nev; set => nev = value; }
        public byte Kozerzet
        {
            get => kozerzet;
            set
            {
                if (kozerzet > 120)
                {
                    kozerzet = 120;
                }
                else
                {
                    kozerzet = value;
                }
            }
        }
        public byte EhsegiMutato
        {
            get => ehsegiMutato;
            set
            {
                if (ehsegiMutato > 120)
                {
                    ehsegiMutato = 120;

                    // Közérzet rontása tulajdonságon keresztül túletetéskor.
                    kozerzet = (byte)(kozerzet - 10);
                    //
                }
                else
                {
                    ehsegiMutato = value;
                }
            }
        }
        public byte EgeszsegMutato { get => egeszsegMutato; set => egeszsegMutato = value; }
        public byte Szomjusag
        {
            get => szomjusag;
            set
            {
                if (szomjusag > 120)
                {
                    szomjusag = 120;

                    // Közérzet rontása tulajdonságon keresztül túlitatáskor.
                    kozerzet = (byte)(kozerzet - 10);
                    //
                }
                else
                {
                    szomjusag = value;
                }
            }

        }

        // Protected Constructor (Abstract)
        protected Allat(string nev, byte kozerzet, byte ehsegiMutato, byte egeszsegMutato, byte szomjusag)
        {
            Nev = nev;
            Kozerzet = kozerzet;
            EhsegiMutato = ehsegiMutato;
            EgeszsegMutato = egeszsegMutato;
            Szomjusag = szomjusag;
        }
        //

        // Main Function
        public abstract int Eves();
        public abstract int Ivas();
        public abstract int Jatek();
        //

        public abstract void AnimalASCIIGraph();

        // Virtualizálás felülírásra
        public virtual string AnimalStatus()
        {
            return $"\n\nKözérzete: {Kozerzet}% , Egészség mutatója: {EgeszsegMutato}% , Jóllakottsága {EhsegiMutato}% , Szomjúság {Szomjusag}%";
        }

        public virtual string MainMenu()
        {
            return Environment.NewLine + $"Az alábbi menüpontokból választhatsz:\n e -- Etetés , i -- Itatás , j -- Játék , ";
        }
        //

        //Fő státuszváltozásért felelős metodus
        public virtual void Eletvitel()
        {
            Console.Clear();

            AnimalASCIIGraph();

            if (EhsegiMutato > 0)
            {
                EhsegiMutato = (byte)(EhsegiMutato - 5);
                Kozerzet = (byte)(Kozerzet - 1);
            }
            if (Szomjusag > 0)
            {
                Szomjusag = (byte)(Szomjusag - 2);
                Kozerzet = (byte)(Kozerzet - 1);
            }
            if (Kozerzet > 0)
            {
                Kozerzet = (byte)(Kozerzet - 1);
            }
            if (EhsegiMutato <= 0 && EgeszsegMutato > 0)
            {
                EgeszsegMutato = (byte)(EgeszsegMutato - 5);
            }

            Console.WriteLine($"{AnimalStatus()}");
        }
        //


    }
}
