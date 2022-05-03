using System;

namespace won4Lab2Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Să se scrie un program care citeşte de la tastatură un şir de n numere 
            //naturale şi determină media aritmetică a celor pare. "n" este citit de la tastatura
            Console.WriteLine("introduceti numarul");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Ati introdus un numar invalid");
                return;
            }

            long suma = 0;
            for (int i = 1; i <= n; i++)
            {
                if(i%2==0)
                {
                    suma += i;
                }
            }

            long mediaAritmetica = suma / (n / 2);

            Console.WriteLine("Media aritmetica este " + mediaAritmetica);
        }
    }
}
