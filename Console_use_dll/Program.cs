using System;
using System.Collections.Generic;
using System.Text;
using DLL_Tinh;

namespace Console_use_dll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, dem = 0;
            Console.WriteLine("Tim uoc cua mot so");
            Console.Write("Nhap so: ");
            n = int.Parse(Console.ReadLine());
            Tinh tinh = new Tinh();
            tinh.n = n;
            tinh.Uoc();
            dem = tinh.dem;
            Console.WriteLine("So uoc cua " + n + " la: " + dem);
            Console.ReadKey();
        }
    }
}
