﻿using System;

namespace Vsite.CSharp
{
    public class Preopterećenje
    {
        public static void MojaMetoda(double broj1, double broj2)
        {
            Console.WriteLine("MojaMetoda(double {0}, double {1})", broj1, broj2);
        }

        public static void MojaMetoda(int broj1, double broj2)
        {
            Console.WriteLine("MojaMetoda(int {0}, double {1})", broj1, broj2);
        }

        static void Main(string[] args)
        {
            int i1 = 1;
            int i2 = 2;
            double d1 = 3;
            double d2 = 4;

            MojaMetoda(i1, i2);
            MojaMetoda(i1, d1);
            MojaMetoda(d1, d2);
            MojaMetoda(d1, i2);

            Console.WriteLine("---------GOTOVO---------");
            Console.ReadKey();
        }
    }
}
