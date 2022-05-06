using System.Globalization;
using System;



namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            int a;

            bool reults = int.TryParse(str, out a);

            if (reults)
            {
                Console.WriteLine("Операция успешно завершена. Результат операции: " + a);
            }
            else
            {
                Console.WriteLine("Конвертация не удалась!");
            }
        }
    }
}