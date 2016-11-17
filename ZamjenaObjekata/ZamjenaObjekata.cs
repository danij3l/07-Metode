using System;

namespace Vsite.CSharp
{
    public class ZamjenaObjekata
    {
        static void Zamijeni(ref object s1, ref object s2)
        {
            object temp = s2;
            s2 = s1;
            s1 = temp;
        }

        public static void ZamjenaStringova(string prvi, string drugi)
        {
            Console.WriteLine("Prije metode Zamijeni:");
            Console.WriteLine("prvi = '{0}'", prvi);
            Console.WriteLine("drugi = '{0}'", drugi);

            object prviString = (object)prvi;
            object drugiString = (object)drugi;
            Zamijeni(ref prviString, ref drugiString);
            prvi = (string)prviString;
            drugi = (string)drugiString;

            Console.WriteLine("Nakon metode Zamijeni:");
            Console.WriteLine("prvi = '{0}'", prvi);
            Console.WriteLine("drugi = '{0}'", drugi);
        }

        public static void ZamjenaIntova(int prvi, int drugi)
        {
            Console.WriteLine("Prije metode Zamijeni:");
            Console.WriteLine("prvi = '{0}'", prvi);
            Console.WriteLine("drugi = '{0}'", drugi);

            // TODO: Promijeniti metodu Zamijeni tako da umjesto tipa string prima tip object i tako podržava zamjenu bilo kojeg tipa objekta. Dodati poziv te metode za 2 argumenta tipa int te provjeriti funkcionalnost.
            object prviInt = (object)prvi;
            object drugiInt = (object)drugi;
            Zamijeni(ref prviInt, ref drugiInt);
            prvi = (int)prviInt;
            drugi = (int)drugiInt;

            Console.WriteLine("Nakon metode Zamijeni:");
            Console.WriteLine("prvi = '{0}'", prvi);
            Console.WriteLine("drugi = '{0}'", drugi);
        }

        static void Main(string[] args)
        {
            string prvi = "prvi";
            string drugi = "drugi";

            ZamjenaStringova(prvi, drugi);

            Console.WriteLine();

            ZamjenaIntova(1, 2);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
