using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть число: ");
        if (int.TryParse(Console.ReadLine(), out int number) && number >= 0)
        {
            int number2 = 1;

            for (int i = 1; i <= number; i++)
            {
                number2 *= i;
            }

            Console.WriteLine("Факторіал дорівнює " + number2);
        }
        else
        {
            Console.WriteLine("Введено некоректне число");
        }
    }
}