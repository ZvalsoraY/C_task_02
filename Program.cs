using System;

namespace C_task_02
{
    public class ConvertToBinary
    {
        public static string DecimalToBinaryOriginal(int n)
        {
            string b = "";
            while (n > 0)
            {
                b = Convert.ToString((n % 2) + b);
                n = n / 2;
            }
            return b;
        }
        public static string DecimalToBinaryStandart(int n)
        {
            return Convert.ToString(n, 2);
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Здравствуйте! Данна программа позволяет конвертировать неотрицательное десятичное значение целого числа в строку, содержащую двоичное представление этого значения.");
            Console.Write("Введите число : ");
            int num = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Результат конвертации станадартным методом: {0}", ConvertToBinary.DecimalToBinaryStandart(num));
            Console.WriteLine("Результат конвертации собственным алгоритмом: {0}", ConvertToBinary.DecimalToBinaryOriginal(num));

            Console.WriteLine("Спасибо, что воспользовались нашей программой.");
            Console.ReadLine();
        }
    }
}
