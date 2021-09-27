using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите числа в массив\n");

            int[] nums = new int[5];

            int value = 0;
            int index = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int count = 1;

                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        count++;
                    }
                }

                if (count <= value)
                {
                    continue;
                }

                value = count;
                index = i;
            }

            Console.WriteLine($"Число {nums[index]} встречается чаще всего {value} раз(а)");
        }
    }
}
