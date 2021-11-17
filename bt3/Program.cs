using System;

namespace test1
{
    class Program
    {
        public static void BT1()
        {
            int w, h;
            do
            {
                Console.Write("w : ");
                w = Convert.ToInt32(Console.ReadLine());
                Console.Write("h : ");
                h = Convert.ToInt32(Console.ReadLine());
            } while (w <= 0 || h <= 0);
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void BT2()
        {
            int n;
            do
            {
                Console.Write("n : ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);
            Console.WriteLine("Ma Tran 1: ");
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(i + 4 * (j - 1) + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Ma Tran 2: ");
            int[,] A = new int[100, 100];
            int d = 0, g = 1, row = n - 1;
            while (d <= n / 2)
            {
                for (int i = d; i <= row; i++) A[d, i] = g++;
                for (int i = d + 1; i <= row; i++) A[i, row] = g++;
                for (int i = row - 1; i >= d; i--) A[row, i] = g++;
                for (int i = row - 1; i > d; i--) A[i, d] = g++;
                row--;
                d++;

            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void BT3()
        {
            Console.Write("a : ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b : ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c : ");
            double c = Convert.ToDouble(Console.ReadLine());

            double x1, x2;
            double delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                x1 = x2 = 0;
                Console.WriteLine("Vo Nghien!");
            }
            else if (delta == 0)
            {
                x1 = x2 = -b / (2 * a);
                Console.WriteLine("Nghiem Chung x = " + x1);
            }
            else
            {
                delta = Math.Sqrt(delta);
                x1 = (-b + delta) / (2 * a);
                x2 = (-b - delta) / (2 * a);
                Console.WriteLine(" x1 = " + x1);
                Console.WriteLine(" x2 = " + x2);
            }
        }
        public static bool checkNT(int n)
        {
            if (n < 2) return false;
            else if (n == 2 || n == 3) return true;
            else
            {
                for (int i = 2; i < Math.Sqrt(n); i++)
                {
                    if (n % i == 0) return false;
                }
            }
            return true;
        }
        public static void BT4()
        {
            int n;
            do
            {
                Console.Write("n : ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);
            Console.Write("So Nguyen To : ");
            for (int i = 2; i <= n; i++)
            {
                if (checkNT(i))
                {
                    Console.Write(i + "  ");
                }
            }
        }

        public static void BT5()
        {
            int n;
            do
            {
                Console.Write("n : ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);
            int[] A = new int[n];
            Console.Write("A[] : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("A[" + i + "] : ");
                A[i] = Convert.ToInt32(Console.Read());
            }
            Console.WriteLine();
            Console.Write("SNT :  ");
            int max = A[0], min = A[0], count = 0;
            for (int i = 1; i < n; i++)
            {
                if (checkNT(A[i]))
                {
                    Console.Write(A[i] + "  ");
                }
                if (A[i] % 2 == 0) count++;
                if (max < A[i]) max = A[i];
                if (min > A[i]) min = A[i];
            }
            Console.Write("\nMax : " + max + "\nMin : " + min + "\nChan : " + count);
            Array.Sort(A);
            Console.Write("x : ");
            int x = Convert.ToInt32(Console.Read());

            for (int i = 0; i < n; i++)
            {
                if (x == A[i])
                    Console.Write(i + " : " + A[i] + "\n");
            }
        }

        public static void BT6()
        {
            int[][] A = new int[4][];
            int sum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                int z = Convert.ToInt32(Console.Read());
                A[i] = new int[z];
                for (int j = 0; j < z; j++)
                {
                    Console.Write("A[{0}][{1}] = ", i, j);
                    A[i][j] = Convert.ToInt32(Console.Read());
                    sum += A[i][j];
                }
            }
            Console.WriteLine("Sum = " + sum);
        }
        static void Main(string[] args)
        {
            int sw;

            sw = Convert.ToInt32(Console.ReadLine());
            switch (sw)
            {
                case 1:
                    BT1();
                    break;
                case 2:
                    BT2();
                    break;
                case 3:
                    BT3();
                    break;
                case 4:
                    BT4();
                    break;
                case 5:
                    BT5();
                    break;

                default:
                    Console.WriteLine("Default");
                    break;
            }


        }
    }
}
