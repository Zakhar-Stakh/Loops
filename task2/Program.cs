using System;

class Program
{
    static void Main()
    {
        int sum = 0;

        for (int i = 1; i <= 100; i++)
        {
            sum += i;
        }

        Console.WriteLine("Сума чисел від 1 до 100 = " + sum);
    }
}