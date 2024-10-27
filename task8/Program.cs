using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть перше число: ");
        if (int.TryParse(Console.ReadLine(), out int number1))
        {
            Console.Write("Введіть друге число: ");
            if (int.TryParse(Console.ReadLine(), out int number2))
            {
                int gcd = FindGCD(number1, number2);
                Console.WriteLine("Найбільший спільний дільник " +
                    "чисел " + number1 + " та " + number2 + ": " + gcd);
            }
            else
            {
                Console.WriteLine("Введено некоректне значення для другого числа.");
            }
        }
        else
        {
            Console.WriteLine("Введено некоректне значення для першого числа.");
        }
    }

    static int FindGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return Math.Abs(a);
    }
}