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
            int[,] playGrid = gridMaker()
            int[, , ] checkGrid = new int[9, 9, 10];
            int[, ] defaultGrid = playGrid;
            Console.WriteLine();
            Console.ReadLine();


        }

        static int[,] gridSolution(int[,] playGrid, int[,,] checkGrid, int[,] default Grid)
        {

        }

        static int[,] gridMaker(int[,] playGrid)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int n = 0; n < 9; n++)
                {
                    playGrid[n, i] = 0;
                }
            }
            return playGrid;
        }
    }
}
