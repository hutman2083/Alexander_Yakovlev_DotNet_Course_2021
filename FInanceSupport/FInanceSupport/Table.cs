using System;
using System.Collections.Generic;
using System.Text;

namespace FInanceSupport
{
    public class Table : String
    {
        const string tableHeader = "ID |\tДоход\t |\tРасход\t |\tПрибыль\t |\tКомментарий|";

        public static void ShowTable()
        {
            Profit.outPutProfits();
            ID.OutputListId();

            int index = 0;

            GetString(tableHeader);

            for (int i = -1; i < Income.index; i++)
            {
                Console.WriteLine($"0{ID.id[index]}|\t{Income.income[index]}\t|\t{Expenses.expenses[index]} \t |\t{Profit.proference[index]}\t | {Comment.commen[index]}|");

                index++;
            }
        }
    }
}
