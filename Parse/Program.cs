using System;
using System.Runtime.InteropServices;

namespace Parse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = ReadInt();

            Console.Write($"Ваше конвертированное число: {value}");
            Console.ReadKey();
        }

        static int ReadInt()
        {

            string userInput;
            int value = 0;

            bool isUserInputRight = false;

            while (isUserInputRight == false)
            {
                Console.Write("Введите число: ");
                userInput = Console.ReadLine();
                Console.Clear();

                isUserInputRight = int.TryParse(userInput, out value);

                if (isUserInputRight == false)
                {
                    Console.WriteLine("Не удалось конвертировать число, попробуйте еще раз.");
                }
            }

            return value;
        }
    }
}
