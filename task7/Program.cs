using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть число: ");
        if (int.TryParse(Console.ReadLine(), out int limit) && limit > 0)
        {
            int sum = 0;
            int count = 0;
            int a = 0;
            int b = 1;

            while (a < limit)
            {
                sum += a;
                count++;

                int next = a + b;
                a = b;
                b = next;
            }

            Console.WriteLine("Сума чисел: " + sum);
            Console.WriteLine("Кількість елементів: " + count);
        }
        else
        {
            Console.WriteLine("Введено некоректне число");
        }
    }
}