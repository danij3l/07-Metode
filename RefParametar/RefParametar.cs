using System;

namespace Vsite.CSharp
{
    public class RefParametar
    {
        static void Main(string[] args)
        {
            PozivMetodeDodajDeset(5);

            PozivMetodePromijeniOsobu(new Osoba("Janko", 1), "Pero", 12);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }

        static void DodajDeset(ref int x)
        {
            x += 10;
        }

        public static int PozivMetodeDodajDeset(int broj)
        {
            Console.WriteLine("Prije metode DodajDeset: {0}", broj);
            DodajDeset(ref broj);
            Console.WriteLine("Nakon metode DodajDeset: {0}", broj);
            return broj;
        }


        public class Osoba
        {
            public Osoba(string ime, int matičniBroj)
            {
                Ime = ime;
                MatičniBroj = matičniBroj;
            }

            public string Ime;
            public int MatičniBroj;

            public override string ToString()
            {
                return string.Format("Ime: {0}, MB: {1}", Ime, MatičniBroj);
            }
        }

        // TODO: Dodati prvom parametru metode modifikator ref tako da se prvi argument
        // osoba metodi prenosi po referenci te promijeniti poziv metode. Pokrenuti program i provjeriti ispis.
        static void PromijeniOsobu(ref Osoba osoba, string novoIme, int noviMatičniBroj)
        {
            osoba = new Osoba(novoIme, noviMatičniBroj);
        }

        public static Osoba PozivMetodePromijeniOsobu(Osoba osoba, string novoIme, int noviMatičniBroj)
        {
            Console.WriteLine(string.Format("Prije metode PromijeniOsobu: {0}", osoba));
            PromijeniOsobu(ref osoba, novoIme, noviMatičniBroj);
            Console.WriteLine(string.Format("Nakon metode PromijeniOsobu: {0}", osoba));
            return osoba;
        }
    }
}
