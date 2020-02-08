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
            int[,] unsolvedGrid = new int[9, 9];
            int[,] solvedGrid = gridMaker();
            Console.WriteLine();
            for (int i = 0; i < 9; i++)
            {
                for (int n = 0; n < 9; n++)
                {
                    Console.WriteLine(solvedGrid[n, i]);
                }
            }
            Console.ReadLine();


        }

        static int randomNumber()
        {
            Random random = new Random();
            return random.Next(1, 9);
        }

        static int[,] gridMaker()
        {
            int generatedNumber = randomNumber();
            int[,] playGrid = new int[9, 9]; 
            for (int i = 0; i < 9; i++)
            {
                for (int n = 0; n < 9; n++)
                {
                    playGrid[i, n] = 0;
                }
            }
            for (int i = 0; i < 9; i++)
            {
                for (int n = 0; n < 9; n++)
                {
                    if (gridChecker(generatedNumber, playGrid, n, i)==0)
                    {
                        playGrid[i, n] = generatedNumber;
                        generatedNumber = randomNumber();
                    }
                    else
                    {
                        n--;
                        generatedNumber = randomNumber();
                    }
                }
            }
            return playGrid;
        }

        static int gridChecker(int generatedNumber, int[,] playGrid, int a, int b)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int n = 0; n < 9; n++)
                {
                    if(generatedNumber == playGrid[b, n])
                    {
                        Console.Write(generatedNumber);
                        return 1;
                    }
                }
                if (generatedNumber == playGrid[i, a])
                {
                    Console.Write(generatedNumber);
                    return 1;
                }
            }
            return 0;
        }
    }
}
