using System;
using System.Collections.Generic;
using System.Text;

namespace FInanceSupport
{
    class Comment
    {
        static public int index = 0;
        public static List<string> commen = new List<string>();

       

        public static void addComment()
        {
            commen.Add(inputComment());
            index++;
        }

        public static void changeComment()
        {
            commen.Insert(index, inputComment());
        }

        public static void deleteComment()
        {
            commen.Insert(index, inputComment());
        }

        public static string inputComment()
        {
           
            Console.WriteLine("Введите ваш комментарий");

            string commen = Console.ReadLine();

            return commen;
        }
    }
}
