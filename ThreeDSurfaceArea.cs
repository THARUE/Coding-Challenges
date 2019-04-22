using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Challenges
{
    /// <summary>
    /// Madison, is a little girl who is fond of toys. Her friend Mason works in a toy manufacturing factory . 
    /// Mason has a 2D board (A) of size (H x W) with  rows and  columns. The board is divided into cells of size (1 x 1)
    /// with each cell indicated by it's coordinate (i , j). The cell (i , j) has an integer (A)ij written on it. 
    /// To create the toy, Mason stacks number of cubes of size (1 x 1 x 1) on the cell (i , j). Given the description of 
    /// the board showing the values of (A)ij and that the price of the toy is equal to the 3d surface area, find the price of the toy.
    /// Input Format:
    /// The first line contains two space-separated integers H and W, the height and the width of the board respectively.
    /// The next lines contains space separated integers. The (j)th integer in  the (i)th line denotes (A)ij.
    /// Output Format:
    /// Print the required answer
    /// </summary>
    class ThreeDSurfaceArea
    {
        /// <summary>
        /// Takes user input from console, and display the 3d surface area 
        /// </summary>
        /// <param name="args"></param>
        /// <created>Andrew Haselden, andrewhaselden@gmail.com ,4/22/2019</created>
        /// <changed>Andrew Haselden, andrewhaselden@gmail.com ,4/22/2019</changed>
        static void Main(string[] args)
        {
            List<List<int>> matrix = new List<List<int>>();

            //take user input defining the size of the matrix
            string dimensions = default;
            do
            {
                Console.WriteLine("Enter the W x H of the matrix:");
                dimensions = Console.ReadLine();

            } while (dimensions.Length < 3);


            //take user input defining the integer values (height of cell) of each row
            string stacks;
            do
            {
                Console.WriteLine("Enter the row's integers: (enter x to quit)");
                stacks = Console.ReadLine();

                if (!stacks.Equals("x"))
                {
                    string[] row = stacks.Split(" ");
                    List<int> rowInts = new List<int>();

                    foreach (var item in row)
                    {
                        rowInts.Add(int.Parse(item));
                    }

                    matrix.Add(rowInts);
                }

            } while (!stacks.Equals("x"));

            //retrieve matrix dimensions from user input
            string[] d = dimensions.Split(" ");
            var h = int.Parse(d[0]);
            var w = int.Parse(d[1]);
            h--;
            w--;

            //time how long it takes to run surface area algorithm
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int result = GetSurfaceArea(matrix, h, w);
            sw.Stop();

            //display results
            Console.WriteLine($"result = {result}\nTiming:  {sw.Elapsed}");
        }

        /// <summary>
        /// Find the 3d surface area 
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="h"></param>
        /// <param name="w"></param>
        /// <returns></returns>
        /// <created>Andrew Haselden, andrewhaselden@gmail.com ,4/22/2019</created>
        /// <changed>Andrew Haselden, andrewhaselden@gmail.com ,4/22/2019</changed>
        public static int GetSurfaceArea(List<List<int>> matrix, int h, int w)
        {
            //calculate the area of all of the top and bottom sides of our cubes
            int surfaceArea = 2 * ((h+1)*(w+1));
            int i = 0,  j = 0;

            //create a matrix for memoization
            int[,] memoMatrix = new int[w+1,h+1];

            //begin recursively getting the surface area of each cell
            GetNodeSurfaceArea(ref matrix, ref memoMatrix, i, j, h, w);

            //add all totals in memo matrix to surface Area
            for (int i2 = 0; i2 < memoMatrix.GetLength(0); i2++)
            {
                for (int i3 = 0; i3 < memoMatrix.GetLength(1); i3++)
                {
                    surfaceArea += memoMatrix[i2,i3];
                }
            }

            return surfaceArea;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="memoMatrix"></param>
        /// <param name="i">row</param>
        /// <param name="j">column</param>
        /// <param name="h">matrix height</param>
        /// <param name="w">matrix width</param>
        /// <created>Andrew Haselden, andrewhaselden@gmail.com ,4/22/2019</created>
        /// <changed>Andrew Haselden, andrewhaselden@gmail.com ,4/22/2019</changed>
        public static void GetNodeSurfaceArea(ref List<List<int>> matrix, ref int[,] memoMatrix, int i, int j, int h, int w)
        {
            int tempArea = default;

            //if a cell is not on top or bottom row
            if (i > 0 && i < w)
            {
                //check up a row
                if (matrix[i - 1][j] < matrix[i][j])
                    tempArea += (matrix[i][j] - matrix[i - 1][j]);
                //check down a row
                if (matrix[i + 1][j] < matrix[i][j])
                    tempArea += (matrix[i][j] - matrix[i + 1][j]);
            }
            //if cell is on the top row
            else if (i == 0)
            {
                //exposed side
                tempArea += matrix[i][j];

                //check down a row
                if (matrix[i + 1][j] < matrix[i][j])
                    tempArea += (matrix[i][j] - matrix[i + 1][j]);
            }
            //if cell is on the bottom row
            else if (i == w)
            {
                //exposed side
                tempArea += matrix[i][j];

                //check up a row
                if (matrix[i - 1][j] < matrix[i][j])
                    tempArea += (matrix[i][j] - matrix[i - 1][j]);
            }
            //if cell is not in first or last column
            if (j > 0 && j < h)
            {
                //check down a column
                if(matrix[i][j-1] < matrix[i][j])
                    tempArea += (matrix[i][j] - matrix[i][j-1]);
                //check up a column
                if (matrix[i][j + 1] < matrix[i][j])
                    tempArea += (matrix[i][j] - matrix[i][j + 1]);
            }
            //if cell is in first column
            else if (j == 0)
            {
                //exposed side
                tempArea += matrix[i][j];

                //look up a column
                if (matrix[i][j+1] < matrix[i][j])
                    tempArea += (matrix[i][j] - matrix[i][j+1]);
            }
            //if cell is in last column
            else if (j == h)
            {
                //exposed side
                tempArea += matrix[i][j];

                //look back a column
                if (matrix[i][j-1] < matrix[i][j])
                    tempArea += (matrix[i][j] - matrix[i][j-1]);
            }

            //save in memo matrix
            memoMatrix[i,j] = tempArea;

            //recurse
            //if cell isn't in last row
            //if that cell's surface area hasn't already been determined
            if (i < w && memoMatrix[i+1, j] == 0)
                GetNodeSurfaceArea(ref matrix, ref memoMatrix, i+1, j, h, w);


            //if cell isn't in last column
            //if that cell's surface area hasn't already been determined
            if (j < h && memoMatrix[i,j+1] == 0)
                GetNodeSurfaceArea(ref matrix, ref memoMatrix, i, j + 1, h, w);

        }
    }
}
