using System;

namespace Task4
{
    class Program
    {
        static void Insert(ref int[] nums, int value, int index )
        {
            int[] newnums = new int[nums.Length + 1];
            newnums[index] = value;
            for (int i = 0; i < index; i++)
            {
                newnums[i] = nums[i];
            }

            for (int i = index; i < nums.Length; i++)
            {
                newnums[i + 1] = nums[i];

            }

            nums = newnums;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число ячеек и элементов в массиве:");
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            for (int i = 0; i < nums.Length - 1; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Введите элемент для добавления в массив:");
            int element = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите позицию в которую хотите добавить элемент");
            int position = int.Parse(Console.ReadLine());
            Insert(ref nums, element, position);
           
            Console.Write("Полученный массив:");
            for (int i = 0; i < nums.Length; i++)
            {
                    Console.Write(nums[i] + " ");
            }

            Console.WriteLine();
            
            



        }
    }
}
