using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenges
{
    class cellState
    {
        #region Problem Description
        /*There is a colony of 8 cells arranged in a straight line 
         * where each day every cell competes with its adjacent cells(neighbour). 
         * Each day, for each cell, if its neighbours are both active or both inactive, 
         * the cell becomes inactive the next day, otherwise it becomes active the next day.
         * => Assumptions
         * The two cells on the ends have single adjacent cell,so the other adjacent cell 
         * can be assumsed to be always inactive. Even after updating the cell state. 
         * consider its previous state for updating the state of other cells. 
         * Update the cell information of all cells simultaneously.
         => Write a fuction cellCompete which takes takes one 8 element array of integers cells 
         representing the current state of 8 cells and one integer days representing the number 
         of days to simulate. An integer value of 1 represents an active cell and value of 0 represents an inactive cell.*/
        #endregion

        public static int[] cellCompete(int[] cells, int N)
        {
            //number of element of state
            int nE = cells.Length;

            // Array to save current state
            int[] saveCells = new int[nE+2];
            saveCells[0] = 0; saveCells[nE + 1] = 0;
            for (int i = 1; i < nE+1; i++)
            {
                saveCells[i] = cells[i-1];
            }
            int k = 1;
            while (k <= N)
            {
                for (int i = 1; i < nE + 1; i++)
                {
                    if (saveCells[i - 1] == saveCells[i + 1])
                    {
                        cells[i - 1] = 0;
                    }
                    else
                    {
                        cells[i - 1] = 1;
                    }
                }
                for (int i = 1; i < nE + 1; i++)
                {
                    saveCells[i] = cells[i - 1];
                }
                k++;
            }

            return cells;
        }

        public static int[] cellCompeteLeet(int[] cells, int N)
        {
            //number of element of state
            int nE = cells.Length;

            // Array to save current state
            int[] saveCells = new int[nE];
            //saveCells[0] = 0; saveCells[nE - 1] = 0;
            for (int i = 0; i < nE ; i++)
            {
                saveCells[i] = cells[i];
            }
            int k = 1;
            while (k <= N)
            {
                saveCells[0] = 0; saveCells[nE - 1] = 0;
                cells[0] = 0; cells[nE - 1] = 0;
                for (int i = 1; i < nE - 1; i++)
                {
                    if (saveCells[i - 1] == saveCells[i + 1])
                    {
                        cells[i] = 0;
                    }
                    else
                    {
                        cells[i] = 1;
                    }
                }
                for (int i = 0; i < nE; i++)
                {
                    saveCells[i] = cells[i];
                }
                k++;
            }

            return cells;
        }

    }
}
