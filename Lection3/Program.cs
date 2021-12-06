using System;
using System.Text;

namespace Lection3
{
    class Program
    {
        static void SumUntilN()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / i;
            }

            Console.WriteLine(sum);
        }

        static void SqrtRow()
        {
            double sum = 0;
            for (int i = 3; i >= 1; i--)
            {
                sum = Math.Sqrt(i + sum);
            }

            Console.WriteLine(sum);
        }

        static void MultiplicationTable()
        {
            for (int j = 2; j <= 9; j++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{j} * {i} = {i * j}");
                }

                Console.WriteLine();
            }
        }

        static void SumUntil()
        {
            double a = Convert.ToDouble(Console.ReadLine());
            int n = 0;
            double sum = 0;
            do
            {
                ++n;
                sum += 1.0 / n;
            } while (sum < a);

            Console.WriteLine(n - 1);
        }

        static void ReverseNumber()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            while (n != 0)
            {
                int currentDigit = n % 10;
                n /= 10;
                result *= 10;
                result += currentDigit;
            }

            Console.WriteLine(result);
        }

        static void WhileUntilMoreThanZero()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            while (num > 0)
            {
                Console.WriteLine(num * num);
                num = Convert.ToInt32(Console.ReadLine());
            }
        }

        static void Ascii()
        {
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine($"{i}\t{(char)i}");
            }
        }

        static void IceCreamLogic()
        {
            Console.Write("Total money:");
            double totalMoney = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ice-cream price:");
            double iceCreamPrice = Convert.ToDouble(Console.ReadLine());
            int count = 0;
            while (totalMoney >= iceCreamPrice)
            {
                totalMoney -= iceCreamPrice;
                ++count;
            }

            Console.WriteLine($"Bought {count} ice-creams" +
                $"and {Math.Round(totalMoney, 2)} money remain.");
        }

        static void Main(string[] args)
        {
            // +=, -=, *=, /=, %=
            //for
            //while
            //dowhile

        }
    }
}
