using System;

class Program
{
    static void Main(string[] args)
    {
        int[,,] arr = new int[2, 2, 3];

        int value = 1;

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    arr[i, j, k] = value++;
                }
            }
        }

        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine($"Layer {i}");

            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    Console.Write(arr[i, j, k] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}