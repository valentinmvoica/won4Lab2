using System;

namespace won5Lab2Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex 2: Scrieti un program care va determina daca un numar este sau nu palindrom.

            Console.WriteLine("introduceti numarul");
            int numar = int.Parse(Console.ReadLine());

            if (numar <= 0)
            {
                Console.WriteLine("Ati introdus un numar invalid");
                return;
            }

            int auxiliar = numar;
            int inversulNumarului = 0;

            while (auxiliar > 0)
            {
                int ultimaCifra = auxiliar % 10;
                auxiliar = auxiliar / 10;

                inversulNumarului = inversulNumarului * 10 + ultimaCifra;
            }

            if (numar == inversulNumarului)
            {
                Console.WriteLine("palindrom");
            }
            else
            {
                Console.WriteLine("nu este palindrom");
            }
        }
    }
}
