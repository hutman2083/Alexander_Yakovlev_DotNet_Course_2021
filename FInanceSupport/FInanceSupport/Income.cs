using System;
using System.Collections.Generic;


namespace FInanceSupport
{
    class Income
    {
        
        static public int index = -1;
        public static List<double> income = new List<double>();
        public static void addIncome()
        {
            income.Add(InputIncome());
            index++;
        }
        public static void deleteIncome()
        {
            Console.WriteLine("Введите номер позиции которую хотите удалить");
            income.RemoveAt(Convert.ToInt32(Console.ReadLine()));
        }
        public static void changeIncome()
        {
            Console.WriteLine("Введите номер позиции в котором хотите поменять значение\n");
            income.Insert(index, InputIncome());
        }
        public static double InputIncome()
        {
            double income;

            Console.WriteLine("Введите ваш доход");

            while (!double.TryParse(Console.ReadLine(), out income))
            {
                Console.WriteLine("Ошибка ввода");
            }
            return income;
        }
        
    }
}
