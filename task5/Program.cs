using System;

class Program
{
    static void Main()
    {
        int sum = 0;

        for (int i = 2; i <= 50; i++)
        {
            if (Primenumber(i))
            {
                sum += i;
            }
        }

        Console.WriteLine("Сума простих чисел = " + sum);
    }

    static bool Primenumber(int number)
    {
        if (number <= 1) return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }

        return true;
    }
}