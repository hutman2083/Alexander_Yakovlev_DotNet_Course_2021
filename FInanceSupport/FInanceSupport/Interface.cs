using System;
using System.Collections.Generic;
using System.Text;

namespace FInanceSupport
{
    public class Interface
    {

    }
    public abstract class String
    {
        const string firstMenuItem = "1 - Добавить доход";
        const string secondMenuItem = "2 - Удалить доход";
        const string thirdMenuItem = "3 - Добавить расход";
        const string fourthMenuItem = "4 - Удалить расход";
        const string fifthMenuItem = "5 - Изменить доход";
        const string sixthMenuItem = "6 - Изменить расход";
        const string seventhMenuItem = "7 - Добавить комментарий";
        const string eighthMenuItem = "8 - Изменить комментарий";
        const string ninthMenuItem = "9 - Удалить комментарий";
        const string tenthMenuItem = "10 - Показать прибыль";
        const string eleventhMenuItem = "11 - Показать таблицу доходов, расходов и прибыли";
        const string twelfthMenuItem = "12 - Выход";
        const string thirteenthMenuItem = "Выберите операцию из предложенного списка =>";

        public static void OutputMenu()
        {
            Console.WriteLine($"{firstMenuItem}\n{secondMenuItem}\n{thirdMenuItem}\n{fourthMenuItem}\n{fifthMenuItem}\n{sixthMenuItem}\n{seventhMenuItem}\n{eighthMenuItem}\n{ninthMenuItem}\n{tenthMenuItem}\n{eleventhMenuItem}\n{twelfthMenuItem}\n{thirteenthMenuItem}");
        }

        public static void GetString(string message)
        {
            Console.WriteLine(message);
        }
    }

}
