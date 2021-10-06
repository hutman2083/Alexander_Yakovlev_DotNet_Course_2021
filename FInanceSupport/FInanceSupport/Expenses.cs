using System;
using System.Collections.Generic;

namespace FInanceSupport
{
    class Expenses
    {
        static public int index = -1;
        public static List<double> expenses = new List<double>();

        public static void addExpenses()
        {
            expenses.Add(InputExpenses());
            index++;
        }
        public static void deleteExpenses()
        {
            Console.WriteLine("Введите номер позиции которую хотите удалить");
            expenses.RemoveAt(Convert.ToInt32(Console.ReadLine()));
        }
        public static void changeExpenses()
        {
            Console.WriteLine("Введите номер позиции в котором хотите поменять значение\n");
            expenses.Insert(index, InputExpenses());
        }
        public static double InputExpenses()
        {
            double expenses;

            Console.WriteLine("Введите ваши расходы");

            while (!double.TryParse(Console.ReadLine(), out expenses))
            {
                Console.WriteLine("Ошибка ввода");
            }
            return expenses;
        }
    }
}
