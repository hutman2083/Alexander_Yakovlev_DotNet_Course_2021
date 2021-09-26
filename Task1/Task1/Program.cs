using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое значение: ");

            string firstValue = Console.ReadLine();

            bool isConverts = Int32.TryParse(firstValue, out int secondValue);

            if (isConverts)
            {
                Console.WriteLine("преобразована в целое число " + secondValue);
            }
            else
            {
                Console.WriteLine("" + firstValue + " нельзя преобразовать в целое число");
            }
        }   
    }
}
    

