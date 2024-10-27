using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть число: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            string binary = Convert.ToString(number, 2);
            Console.WriteLine(binary);
        }
        else
        {
            Console.WriteLine("Введено некоректне число");
        }
    }
}