using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterWindows printer;

            Console.WriteLine("Pilih printer:");
            Console.WriteLine("1. Canon");
            Console.WriteLine("1. Epson");
            Console.WriteLine("1. LaserJet\n");

            Console.Write("Nomor printer [1..3]: ");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());

            if (nomorPrinter == 1)
            {
                printer = new Canon();
            }
            else if (nomorPrinter == 2)
            {
                printer = new Epson();
            }
            else
            {
                printer = new LaserJet();
            }

            printer.Show();
            printer.Print();

            Console.ReadKey();
        }
    }
}