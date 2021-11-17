using System;
using System.Collections;

namespace BTTH_4
/**
*
* @author Bui Hoang Ha
*/
{
    class Program
    {
        static void Bai1()
        {
            int n; double x;
            ArrayList arrList = new ArrayList();
            arrList.Add(-3.4);
            arrList.Add(2.45);
            arrList.Add(329.412);
            arrList.Add(0.4112);
            Console.Write("Nhap so thuc x= ");
            x = Convert.ToDouble(Console.ReadLine());
            arrList.Add(x);
            for (int i = 0; i < arrList.Count; i++)
            {
                Console.WriteLine(arrList[i]);
            }

            arrList.Sort();
            Console.WriteLine("\nSap xep mang tang dan: ");
            foreach (double a in arrList)
            {
                Console.WriteLine(a);
            }

            double timKiem; int dem = 0;
            Console.WriteLine("Nhap so thuc de tim kiem: ");
            timKiem = Convert.ToDouble(Console.ReadLine());
            foreach (double a in arrList)
            {
                if (timKiem == a)
                {
                    dem++;
                }
            }
            Console.WriteLine("Co " + dem + " gia tri bang " + timKiem);

            for(int i = 0;i<arrList.Count;i++)
            {
                if ((double)arrList[i] < 0)
                {
                    arrList.Remove(arrList[i]);
                }
            }

            Console.WriteLine("Sau khi xoa cac phan tu am: ");

            foreach (double a in arrList)
            {
                Console.WriteLine(a);
            }
        }
        static void Main(string[] args)
        {
            Bai1();

            Console.ReadKey();
        }
    }
}
