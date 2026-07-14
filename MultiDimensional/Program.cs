using System;

class MultiDimensionalProgram
{
    static void Main(string[] args)
    {
        int[,,] cube = new int[2, 2, 2]
        {
            {
                { 1, 2 },
                { 3, 4 }
            },
            {
                { 5, 6 },
                { 7, 8 }
            }
        };

        Console.WriteLine("3D Array:");
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("Layer " + i + ":");
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    Console.Write(cube[i, j, k] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}