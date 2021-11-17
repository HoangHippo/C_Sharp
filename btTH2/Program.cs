using System;

namespace btTH2
{
    class Program
    {
        static void Bt1()
        {
            int a, b, c;
            Console.Write("Nhap cac so can so sanh la :");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            int max = a;
            if(b>max) { max = b; }
            if(c>max) { max = c; }
            Console.WriteLine("So lon nhat la {0}, max");
        }
    }
        static void Bai2()
        {
            Console.Write("Nhap 1 so tu 0 den 9: ");
            int x = Convert.ToInt32(Console.ReadLine());
            switch (x)
        {
            case 0: { Console.WriteLine("Khong"); break; }
            case 1: { Console.WriteLine("Mot"); break; }
            case 2: { Console.WriteLine("Hai"); break; }
            case 3: { Console.WriteLine("Ba"); break; }
            case 4: { Console.WriteLine("Bon"); break; }
            case 5: { Console.WriteLine("Nam"); break; }
            case 6: { Console.WriteLine("Sau"); break; }
            case 7: { Console.WriteLine("Bay"); break; }
            case 8: { Console.WriteLine("Tam"); break; }
            case 9: { Console.WriteLine("Chin"); break; }
        }
    }
    static void get(int vt, int[] arr)
    {
        if (vt == 7) return;
        switch (vt)
        {
            case 1:
                Console.Write("trieu ");
                break;
            case 4:
                if (!((arr[vt] == 0) && (arr[vt - 1] == 0) && (arr[vt - 2] == 0)))
                    Console.Write("nghin ");
                break;
            case 2:
                if (!(((arr[vt + 2] == 0) && (arr[vt + 1] == 0)) && (arr[vt] == 0)))
                    Console.Write("tram ");
                break;
            case 5:
                if (!(((arr[vt + 2] == 0) && (arr[vt + 1] == 0)) && (arr[vt] == 0)))
                    Console.Write("tram ");
                break;

            case 3:
            case 6:
                if (arr[vt] != 0)
                    Console.Write("muoi ");
                else
                {
                    if (arr[vt + 1] != 0)
                        Console.Write("le ");
                }
                break;
        }
    }

    static void Bai3()
    {
        string[] mau = { "khong ", "mot ", "hai ", "ba ", "bon ", "nam ", "sau ", "bay ", "tam ", "chin " };
        int n;
        while (true)
        {
            Console.WriteLine("Nhap so nguyen duong: ");
            n = Convert.ToInt32(Console.ReadLine());

            if ((n >= 0) && (n <= 9999999)) break;
            else Console.WriteLine("Nhap sai yeu cau nhap lai!");
        }

        int i; int[] arr = new int[10];
        for (i = 1; i <= 7; i++)
            arr[i] = 0;
        i = 7;
        while (n != 0)
        {
            arr[i] = n % 10;
            n = n / 10;
            i--;
        }

        int vtd = 8;
        for (i = 1; i <= 7; i++)
            if (arr[i] != 0)
            {
                vtd = i;
                break;
            }
        if (vtd == 😎)
            {
            Console.Write("khong");
            return;
        }
        for (i = vtd; i <= 7; i++)
        {
            switch (arr[i])
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 6:
                case 7:
                case 8:
                case 9:
                    if (!((arr[i] == 1) && ((i == 6) || (i == 3))))
                        Console.Write(mau[arr[i]]);
                    get(i, arr);
                    break;
                case 5:
                    if (i == 7)
                    {
                        if (arr[i - 1] == 0)
                            Console.Write("nam ");
                        else
                            Console.Write("lam ");
                    }
                    else
                    {
                        if (i == 4)
                        {
                            if (arr[i - 1] == 0)
                                Console.Write("nam ");
                            else
                                Console.Write("lam ");
                        }
                        else
                            Console.Write(mau[arr[i]]);
                        get(i, arr);
                    }
                    break;
                case 0:
                    if (((i == 5) || (i == 2)) && ((arr[i + 2] != 0) || ((arr[i + 1] != 0))))
                        Console.Write(mau[arr[i]]);
                    get(i, arr);
                    break;
            }
        }
    }
    static void Main(string[] args)
    {
        //Bai1();
        //Bai2();
        Bai3();
        Console.ReadKey();
    }
}


        