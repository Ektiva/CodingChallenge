using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenges
{
    #region Problem Description
    /*In a given grid, each cell can have one of three values:
    - the value 0 representing an empty cell;
    - the value 1 representing a fresh orange;
    - the value 2 representing a rotten orange.
    Every minute, any fresh orange that is adjacent (4-directionally) to a rotten orange becomes rotten.

    Return the minimum number of minutes that must elapse until no cell has a fresh orange.If this is impossible, return -1 instead.
    Note:
    a. 1 <= grid.length <= 10
    b. 1 <= grid[0].length <= 10
    c. grid[i][j] is only 0, 1, or 2.*/
    #endregion
    class rottingOrange
    {
        //Method to Check if the given coordonates is insinde the bound of the array
        public static Boolean isInside(int i, int j, int[][] grid)
        {
            return (i >= 0 && i < grid.Length && j >=0 && j < grid[0].Length);
        }
        //Method to solve the problem
        public static int minTime(int[][] grid)
        {
            int nR = grid.Length; int nC = grid[0].Length;

            //Array to Check if a record or grid array was visited or not
            Boolean[][] isVisited = new Boolean[nR][];
            for (int i = 0; i < nR; i++) 
            {
                isVisited[i] = new Boolean[nC];
            }

            //Queue to store all rotten oranges
            Queue<Point> rotOrgQ = new Queue<Point>();
            for (int i = 0; i < nR; i++)
            {
                for (int j = 0; j < nC; j++)
                {
                    if(grid[i][j] == 2)
                    {
                        rotOrgQ.Enqueue(new Point(i, j, 0));
                        isVisited[i][j] = true;
                    }
                }
            }

            //Value to return 
            int myAns = 0;

            while (rotOrgQ.Count != 0)
            {
                //Take first rotten orange in the Queue and Check if it have neigbor to rotte 
                Point P = rotOrgQ.Dequeue();

                myAns = Math.Max(myAns, P.counter);

                //Check the TOP of that rotten orange and rotte if it contain a fesh orange
                if(isInside(P.x-1, P.y, grid) && !isVisited[P.x-1][P.y] && grid[P.x-1][P.y] == 1)
                {
                    rotOrgQ.Enqueue(new Point(P.x - 1, P.y, P.counter+1));
                    grid[P.x - 1][P.y] = 2;
                    isVisited[P.x - 1][P.y] = true;
                }

                //Check the BUTTOM of that rotten orange and rotte if it contain a fesh orange
                if (isInside(P.x + 1, P.y, grid) && !isVisited[P.x + 1][P.y] && grid[P.x + 1][P.y] == 1)
                {
                    rotOrgQ.Enqueue(new Point(P.x + 1, P.y, P.counter + 1));
                    grid[P.x + 1][P.y] = 2;
                    isVisited[P.x + 1][P.y] = true;
                }

                //Check the RIGHT of that rotten orange and rotte if it contain a fesh orange
                if (isInside(P.x, P.y + 1, grid) && !isVisited[P.x][P.y + 1] && grid[P.x][P.y + 1] == 1)
                {
                    rotOrgQ.Enqueue(new Point(P.x, P.y + 1, P.counter + 1));
                    grid[P.x][P.y + 1] = 2;
                    isVisited[P.x][P.y + 1] = true;
                }

                //Check the LEFT of that rotten orange and rotte if it contain a fesh orange
                if (isInside(P.x, P.y - 1, grid) && !isVisited[P.x][P.y - 1] && grid[P.x][P.y - 1] == 1)
                {
                    rotOrgQ.Enqueue(new Point(P.x, P.y - 1, P.counter + 1));
                    grid[P.x][P.y - 1] = 2;
                    isVisited[P.x][P.y - 1] = true;
                }
            }
            for (int i = 0; i < nR; i++)
            {
                for (int j = 0; j < nC; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        return -1;
                    }
                }
            }
            return myAns;
        }
    }
}
 