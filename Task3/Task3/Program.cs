using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число элементов в массиве\n");

            int[] nums = new int[5];

            int repeatvalue = 0;

            int index = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int schitatel = 1;

                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        schitatel++;
                    }
                }

                if (schitatel <= repeatvalue)
                {
                    continue;
                }
                repeatvalue = schitatel;

                index = i;
            }

            Console.WriteLine($"Число {nums[index]} встречается чаще всего {repeatvalue} раз(а)");
        }
    }
}
