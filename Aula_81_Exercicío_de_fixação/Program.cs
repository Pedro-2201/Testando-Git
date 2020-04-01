using System;

namespace Aula_81_Exercicío_de_fixação
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            string[] size = Console.ReadLine().Split(' ');
            int lines = int.Parse(size[0]);
            int columns = int.Parse(size[1]);

            int[,] mat = new int[lines, columns];

            for (int x = 0; x < lines; x++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int y = 0; y <  columns; y++)
                {
                    mat[x, y] = int.Parse(values[y]);
                }
            }

            Console.Write("Write a number: ");
            int number = int.Parse(Console.ReadLine());
            if (number != null)
            {
                for (int l = 0; l < lines; l++)
                {
                    for (int  c = 0; c < columns; c++)
                    {
                        if (mat[l, c] == number)
                        {
                            Console.WriteLine("Position: " + l + "," + c);
                            if (c > 0)
                            {
                                Console.WriteLine("Left: " + mat[l, c - 1]);
                            }
                            if (c < columns - 1)
                            {
                                Console.WriteLine("Right: " + mat[l, c + 1]);
                            }
                            if (l > 0)
                            {
                                Console.WriteLine("Up: " + mat[l - 1, c]);
                            }
                            if (l < lines - 1)
                            {
                                Console.WriteLine("Down: " + mat[l + 1, c]);
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Number dosen't exist");
            }

        }
    }
}
