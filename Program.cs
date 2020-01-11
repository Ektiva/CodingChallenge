using System;

namespace CodingChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");

            #region Rotting Orange Test

            //int[][] arr = new int[][]
            //{
            //new int[] {2, 1, 0, 2, 1},
            //new int[] {1, 0, 1, 2, 1},
            //new int[] {1, 0, 0, 2, 1}
            //};

            //int[][] arr1 = new int[][]
            //{
            //new int[] {2, 1, 1},
            //new int[] {0, 1, 1},
            //new int[] {1, 0, 1}
            //};

            //int[][] arr2 = new int[][]
            //{
            //new int[] {2, 1, 1},
            //new int[] {1, 1, 0},
            //new int[] {0, 1, 1}
            //};

            //int myAns = rottingOrange.minTime(arr2);
            //Console.WriteLine("The answer is: " +myAns);

            //if (myAns == -1)
            //{
            //    Console.WriteLine("All oranges cannot rot");
            //}
            //else
            //{
            //    Console.WriteLine("Time required for all " +
            //                    "oranges to rot => " + myAns);
            //}
            #endregion

            #region Cell State Test
            //int[] cell = new int[8] {1, 0, 0, 0, 0, 1, 0, 0}; int N = 1;
            //int[] cell = new int[8] { 0, 1, 0, 1, 1, 0, 0, 1 }; int N = 7;
            int[] cell = { 0, 1, 0, 1, 0, 1, 0, 1 }; int N = 1;


            Console.Write("Input =  [ ");
            for (int i = 0; i < cell.Length; i++)
            {
                Console.Write(cell[i] + " ");
            }
            Console.Write("], N  = " + N);
            Console.WriteLine("");

            int[] cellAfter = cellState.cellCompeteLeet(cell, N);
            Console.Write("Output = [ ");
            for (int i = 0; i < cellAfter.Length; i++)
            {
                Console.Write(cellAfter[i] + " ");
            }
            Console.Write("]");
            Console.WriteLine("");
            #endregion
        }
    }
}
