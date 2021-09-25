using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое значение: ");

            string Firstvalue = Console.ReadLine();

            bool Secondvalue = Int32.TryParse(Firstvalue, out int SecondValue);

            if (Secondvalue)
            {
                Console.WriteLine("преобразована в целое число " + Secondvalue);
            }
            else
            {
                Console.WriteLine("" + Firstvalue + " нельзя преобразовать в целое число");
            }
        }   
    }
}
    

