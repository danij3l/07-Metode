using System;

namespace Vsite.CSharp
{
    public class OutParametar
    {
        static void InicijalizirajBrojNaDeset(out int x)
        {
            x = 10;
        }

        public static void PozivInicijalizacijeOutParametrom()
        {
            int x = 0;
            InicijalizirajBrojNaDeset(out x);
            Console.WriteLine(string.Format("Nakon InicijalizirajBrojNaDeset: {0}", x));
        }

        static void Main(string[] args)
        {
            PozivInicijalizacijeOutParametrom();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
