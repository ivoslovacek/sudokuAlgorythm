using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sudokualgorythm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] grid = new int[9, 9];
            for(int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    grid[i, j] = 0;
                }
            }
            grid[0, 0] = 5;
            grid[0, 1] = 3;
            grid[0, 4] = 7;
            grid[1, 0] = 6;
            grid[1, 3] = 1;
            grid[1, 4] = 9;
            grid[1, 5] = 5;
            grid[2, 1] = 9;
            grid[2, 2] = 8;
            grid[2, 7] = 6;
            grid[3, 0] = 8;
            grid[3, 4] = 6;
            grid[3, 8] = 3;
            grid[4, 0] = 4;
            grid[4, 3] = 8;
            grid[4, 5] = 3;
            grid[4, 8] = 1;
            grid[5, 0] = 7;
            grid[5, 4] = 2;
            grid[5, 8] = 6;
            grid[6, 1] = 6;
            grid[6, 6] = 2;
            grid[6, 7] = 8;
            grid[7, 3] = 4;
            grid[7, 4] = 1;
            grid[7, 5] = 9;
            grid[7, 8] = 5;
            grid[8, 4] = 8;
            grid[8, 7] = 7;
            grid[8, 8] = 9;
            gridSolution(grid);
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(grid[i,j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();


        }

        static int randomNumber()
        {
            Random random = new Random();
            return random.Next(1, 9);
        }

        static bool gridSolution(int[,] grid)
        {
            int[] empty = gridEmpty(grid);
            if(empty[2] == 1)
            {
                return true;
            }
            for(int i = 1; i < 10; i++)
            {
                if (gridValid(grid, i, empty)==true)
                {
                    grid[empty[0],empty[1]] = i;
                    if (gridSolution(grid) == true)
                    {
                        return true;
                    }
                    grid[empty[0], empty[1]] = 0;
                }
            }
            return false;
        }

        static bool gridValid(int[,] grid,int generatedNumber,int[] pos)
        {
            for(int i = 0; i < 9 ; i++)
            {
                if(grid[pos[0], i] == generatedNumber && pos[0] != i)
                {
                    return false;
                }
                if (grid[i, pos[1]] == generatedNumber && pos[0] != i)
                {
                    return false;
                }
            }
            int grid_x = pos[0] / 3;
            int grid_y = pos[1] / 3;
            for(int i = grid_y * 3; i < grid_y * 3 + 3; i++)
            {
                for(int j = grid_x * 3; j < grid_x * 3 +3; j++)
                {
                    if(grid[j,i] == generatedNumber && (pos[0] != j && pos[1] != i))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        static int[] gridEmpty(int[,] grid)
        {
            int[] empty = new int[3];
            for (int i = 0; i < 9; i++)
            {
                for(int j = 0; j < 9; j++)
                {
                    if(grid[i,j] == 0)
                    {
                        empty[0] = i;
                        empty[1] = j;
                        empty[2] = 0;
                        return empty;
                    }
                }
            }
            empty[2] = 1;
            return empty;
        }
    }
}
