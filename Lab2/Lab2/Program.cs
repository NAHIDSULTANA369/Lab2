using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Problem_1
            int n = 100;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine("Even Number:" + i);
            }


            //Problem_2
            n = 5;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("0X0X0X");
                }

                else
                    Console.WriteLine("X0X0X0");
            }

            Console.WriteLine();



            //Problem_3
            for (int i = 1; i <= n; i++)
            {
                int j = i + 1, k = i + 2, l = i + 3, m = i + 4;
                Console.WriteLine(i + "" + j + "" + k + "" + l + "" + m + "");
            }
            Console.WriteLine();



            //Problem_4
            int odd_sum = 0;
            for(int i=1;i<=100;i++)
            {
                odd_sum = odd_sum + i;
                i = i + 2;

            }
            Console.WriteLine("Sum of odd number =" + odd_sum);
            int even_sum = 0;
            for(int j=2;j<=100;j++)
            {
                even_sum = even_sum + j;
                j = j + 2;
            }
            Console.WriteLine("Sum of even number =" + even_sum);
            Console.WriteLine();



            //Problem_5
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.WriteLine(" ");
                }
                Console.WriteLine(i);

            }
            Console.WriteLine();



            //Problem_6
            int p = 5, q = 1;
            for(int i = 1; i<=p; i++)
            {
                q = q * i;
            }
            Console.WriteLine("Factoria is:" + q);



            //Problem_7
            p = 5;
            for (int i = 1; i <= p; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine();
            }

            for (int i = p - 1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine();
            }
        }
    }
}
