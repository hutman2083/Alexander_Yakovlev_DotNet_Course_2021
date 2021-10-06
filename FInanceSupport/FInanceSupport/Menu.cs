using System;

namespace FInanceSupport
{
    class Menu : String
    {
        static void Main(string[] args)
        {
            ShowMenu();
        
        }
        public static bool flag = true;

        enum Item
        {
            addIncome = 1,
            deleteIncome,
            addExpense,
            deleteExpense,
            changeIncome,
            changeExpense,
            addComment,
            changeComment,
            deleteComment,
            showProfit,
            showTable,
            outProgram
        }

        public static void ShowMenu()
        {

            while (flag)
            {

                Console.WriteLine("Выберите операцию");
                Console.WriteLine("1 - Добавить доход");
                Console.WriteLine("2 - Удалить доход");
                Console.WriteLine("3 - Добавить расход");
                Console.WriteLine("4 - Удалить расход");
                Console.WriteLine("5 - Изменить доход");
                Console.WriteLine("6 - Изменить расход");
                Console.WriteLine("7 - Добавить комментарий");
                Console.WriteLine("8 - Изменить комментарий");
                Console.WriteLine("9 - Удалить комментарий");
                Console.WriteLine("10 - Показать прибыль");
                Console.WriteLine("11 - Показать таблицу доходов и расходов");
                Console.WriteLine("12 - Выход");
                Console.Write("Выберите задание => ");

                Item itemMenu = (Item)int.Parse(Console.ReadLine());

                switch (itemMenu)
                {
                    case Item.addIncome:
                        {
                            Income.addIncome();
                            break;
                        }
                    case Item.deleteIncome:
                        {
                            Income.deleteIncome();
                            break;
                        }
                    case Item.addExpense:
                        {
                            Expenses.addExpenses();
                            break;
                        }
                    case Item.deleteExpense:
                        {
                            Expenses.deleteExpenses();
                            break;
                        }
                    case Item.changeIncome:
                        {
                            Income.changeIncome();
                            break;
                        }
                    case Item.changeExpense:
                        {
                            Expenses.changeExpenses();
                            break;
                        }
                   
                    case Item.addComment:
                        {
                            Comment.addComment();
                            break;
                        }
                    case Item.deleteComment:
                        {
                            Comment.deleteComment();
                            break;
                        }
                    case Item.changeComment:
                        {
                            Comment.changeComment();
                            break;
                        }
                    case Item.showProfit:
                        {
                            Profit.outPutProfits();
                            break;
                        }
                    case Item.showTable:
                        {
                            Table.ShowTable();
                            break;
                        }
                    case Item.outProgram:
                        {
                            flag = false;

                            break;
                        }
                }
            }
        }
    }
}
