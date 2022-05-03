using System;

namespace won4Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Scrieti un program care va afisa factorialul unui numar n, n fiind citit de la tastatura
            Console.WriteLine("introduceti numarul");
            int numar = int.Parse(Console.ReadLine());

            if(numar<=0)
            {
                Console.WriteLine("Ati introdus un numar invalid");
                return;
            }

            long factorial = 1;
            
            for (int i = 1; i <= numar; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine(factorial);
        }
    }
}
