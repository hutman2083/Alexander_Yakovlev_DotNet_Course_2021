using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите 3 числа\n");
            double Firstvalue = Convert.ToDouble(Console.ReadLine());
            double Secondvalue = Convert.ToDouble(Console.ReadLine());
            double Thirdvalue = Convert.ToDouble(Console.ReadLine());

            if (Firstvalue < Secondvalue && Firstvalue < Thirdvalue)
            {
                Console.WriteLine("Минимальное значение = " + Firstvalue);
                
            }

            else if (Secondvalue < Firstvalue && Secondvalue < Thirdvalue)
            {
                Console.WriteLine("Минимальное значение = " + Secondvalue);
               
            }

            else
            {
                Console.WriteLine("Минимальное значение = " + Thirdvalue);
                
            }

            if (Firstvalue > Secondvalue && Firstvalue > Thirdvalue)
            {
                Console.WriteLine("Максимальное значение = " + Firstvalue);
               
            }

            else if (Secondvalue > Firstvalue && Secondvalue > Thirdvalue)
            {
                Console.WriteLine("Максимальное значение = " + Secondvalue);
                
            }

            else
            {
                Console.WriteLine("Максимальное значение = " + Thirdvalue);
                
            }
            Console.Write("В порядке возрастания:\n");

            if (Firstvalue < Secondvalue && Firstvalue < Thirdvalue)
            {
                Console.WriteLine(Firstvalue);
                Console.WriteLine(Math.Min(Secondvalue, Thirdvalue));
                Console.WriteLine(Math.Max(Secondvalue, Thirdvalue));
            }

            else if (Secondvalue < Firstvalue && Secondvalue < Thirdvalue)
            {
                Console.WriteLine(Secondvalue);
                Console.WriteLine(Math.Min(Firstvalue, Thirdvalue));
                Console.WriteLine(Math.Max(Firstvalue, Thirdvalue));
            }

            else
            {
                Console.WriteLine(Thirdvalue);
                Console.WriteLine(Math.Min(Firstvalue, Secondvalue));
                Console.WriteLine(Math.Max(Firstvalue, Secondvalue));
            }
            Console.Write("В порядке убывания:\n");

            if (Firstvalue > Secondvalue && Firstvalue > Thirdvalue)
            {
                Console.WriteLine(Firstvalue);
                Console.WriteLine(Math.Min(Secondvalue, Thirdvalue));
                Console.WriteLine(Math.Max(Secondvalue, Thirdvalue));
            }

            else if (Secondvalue > Firstvalue && Secondvalue > Thirdvalue)
            {
                Console.WriteLine(Secondvalue);
                Console.WriteLine(Math.Min(Firstvalue, Thirdvalue));
                Console.WriteLine(Math.Max(Firstvalue, Thirdvalue));
            }

            else
            {
                Console.WriteLine(Thirdvalue);
                Console.WriteLine(Math.Min(Firstvalue, Secondvalue));
                Console.WriteLine(Math.Max(Firstvalue, Secondvalue));
            }
            Console.ReadKey();
        }       
    }
}
