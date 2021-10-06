using System;
using System.Collections.Generic;
using System.Text;

namespace FInanceSupport
{
    class Profit
    {
        public static List<double> proference = new List<double>();

        public static void OutputProfit()
        {
            int index = 0;

            for (int i = -1; i < Income.index; i++)
            {
                proference.Add(Income.income[index] - Expenses.expenses[index]);

                index++;
            }

        }

        public static void outPutProfits()
        {
            OutputProfit();
            foreach(var item in proference)
            {
                Console.WriteLine($"\t |{item}|");
            }
        }

        
    }
}
