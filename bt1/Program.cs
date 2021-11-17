using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class Program
    {
        static void VeHCN()
        {
            int rong, dai;
            Console.WriteLine("Nhap chieu rong HCN: ");
            rong = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap chieu dai HCN:");
            dai = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < rong; i++)
            {
                for (int j = 0; j < dai; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            VeHCN();
            Console.ReadKey();
        }
    }
}