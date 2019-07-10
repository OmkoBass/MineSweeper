using System;

namespace MineSweeper
{
    class Program
    {
        
        static void createTable(int[,] mat, int size)
        {
            Random r = new Random();
            for(int i = 0; i < mat.GetLenght(); i++)
            {
                for(int j = 0; j < size; j++)
                {
                    int temp = r.Next(0, 8);
                    if (temp == 4)
                    {
                        mat[i, j] = 9;
                    }
                    else
                    {
                        mat[i, j] = 0;
                    }
                }
            }
        }

        static void displayTable(int [,] mat, int size)
        {
            Console.WriteLine("BROJ 9 ZNACI MINA!");
            for(int i = 0; i < size; i++)
            {
                Console.Write(i + ": ");
                for(int j = 0; j < size; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
        }

        static void displayDanger(int[,] mat, int size)
        {
            int p, q;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (mat[i, j] == 9)
                    {
                        p = i;
                        q = j;
                        for (int k = p - 1; k < p + 2; k++)
                        {
                            for (int l = q - 1; l < q + 2; l++)
                            {
                                try
                                {
                                    if (mat[k, l] != 9) { mat[k, l]++; }
                                }
                                catch
                                {
                                    continue;
                                }
                            }
                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[,] matrix = new int[9,9];
            createTable(matrix, 9);
            displayTable(matrix, 9);
            displayDanger(matrix, 9);
            displayTable(matrix, 9);
        }
    }
}
