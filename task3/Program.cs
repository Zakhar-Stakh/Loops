using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.Write("Введіть число ");
            int number1 = int.Parse(Console.ReadLine());

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= number1;
            }



            Console.WriteLine("Таблиця");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
