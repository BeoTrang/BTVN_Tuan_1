using System;
using System.Collections.Generic;
using System.Text;

namespace Console_usen_t_dll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n, dem = 0;
            Console.WriteLine("Tim uoc cua mot so");
            Console.Write("Nhap so: ");
            try
            {
                n = int.Parse(Console.ReadLine());
                for (i = 1; i <= n; i++)
                {
                    if (n % i == 0) dem++;
                }
                Console.WriteLine("So uoc cua " + n + " la: " + dem);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi: " + ex.Message);
            }
            Console.ReadKey();
        }
    }
}
