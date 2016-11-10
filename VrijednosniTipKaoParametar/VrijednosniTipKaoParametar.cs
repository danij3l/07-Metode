using System;

namespace Vsite.CSharp
{
    public class VrijednosniTipKaoParametar
    {
        static void Uvećaj(int n)
        {
            n += 1;
            Console.WriteLine("U metodi Uvećaj: {0}", n);
        }

        public struct Osoba
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

        public static void PromijeniOsobu(Osoba o)
        {
            Console.WriteLine("U metodi PromijeniOsobu stavljam novu osobu:");
            o = new Osoba("Pero", 2);
            Console.WriteLine(o);
            Console.WriteLine("Nakon povratka iz Metode PromijeniOsobu:");
        }

        public static void PromijeniIme(Osoba o, string novoIme)
        {
            Console.WriteLine(string.Format("U metodi PromijeniIme mijenjam ime u {0}", novoIme));
            o.Ime = novoIme;
            Console.WriteLine(o);
            Console.WriteLine("Nakon povratka iz metode PromijeniIMe:");
        }

        static void Main(string[] args)
        {

            int n = 5;
            Console.WriteLine("Prije metode Uvećaj: {0}", n);

            Uvećaj(n);

            Console.WriteLine("Nakon metode Uvećaj: {0}", n);

            Console.WriteLine();

            Osoba janko = new Osoba("Janko", 1);
            PromijeniOsobu(janko);
            Console.WriteLine(janko);

            PromijeniIme(janko, "Pero");
            Console.WriteLine(janko);

            Console.WriteLine("----------GOTOVO----------");
            Console.ReadKey();
        }
    }
}
