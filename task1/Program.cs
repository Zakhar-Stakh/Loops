using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Парні числа від 1 до 20:");

        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}