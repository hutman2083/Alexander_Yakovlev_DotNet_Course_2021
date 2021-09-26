using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите 3 числа\n");

            double firstValue = Convert.ToDouble(Console.ReadLine());
            double secondValue = Convert.ToDouble(Console.ReadLine());
            double thirdValue = Convert.ToDouble(Console.ReadLine());

            if (firstValue < secondValue && firstValue < thirdValue)
            {
                Console.WriteLine("Минимальное значение = " + firstValue);
            }
            else if (secondValue < firstValue && secondValue < thirdValue)
            {
                Console.WriteLine("Минимальное значение = " + secondValue);
            }
            else
            {
                Console.WriteLine("Минимальное значение = " + thirdValue);
            }

            if (firstValue > secondValue && firstValue > thirdValue)
            {
                Console.WriteLine("Максимальное значение = " + firstValue);
            }
            else if (secondValue > firstValue && secondValue > thirdValue)
            {
                Console.WriteLine("Максимальное значение = " + secondValue);
            }
            else
            {
                Console.WriteLine("Максимальное значение = " + thirdValue);
            }

            Console.Write("В порядке возрастания:\n");

            if (firstValue < secondValue && firstValue < thirdValue)
            {
                Console.WriteLine(firstValue);
                Console.WriteLine(Math.Min(secondValue, thirdValue));
                Console.WriteLine(Math.Max(secondValue, thirdValue));
            }
            else if (secondValue < firstValue && secondValue < thirdValue)
            {
                Console.WriteLine(secondValue);
                Console.WriteLine(Math.Min(firstValue, thirdValue));
                Console.WriteLine(Math.Max(firstValue, thirdValue));
            }
            else
            {
                Console.WriteLine(thirdValue);
                Console.WriteLine(Math.Min(firstValue, secondValue));
                Console.WriteLine(Math.Max(firstValue, secondValue));
            }

            Console.Write("В порядке убывания:\n");

            if (firstValue > secondValue && firstValue > thirdValue)
            {
                Console.WriteLine(firstValue);
                Console.WriteLine(Math.Max(secondValue, thirdValue));
                Console.WriteLine(Math.Min(secondValue, thirdValue));
            }
            else if (secondValue > firstValue && secondValue > thirdValue)
            {
                Console.WriteLine(secondValue);
                Console.WriteLine(Math.Max(firstValue, thirdValue));
                Console.WriteLine(Math.Min(firstValue, thirdValue));
            }
            else
            {
                Console.WriteLine(thirdValue);
                Console.WriteLine(Math.Max(firstValue, secondValue));
                Console.WriteLine(Math.Min(firstValue, secondValue));
            }

            Console.ReadKey();
        }
    }
}
