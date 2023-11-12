using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Assignment_TASK_1_10th_nov_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  int[][] matrix;


            // matrix = new int[3][];
            //  matrix[0] = new int[4] { 1, 2, 3, 4 };   
            //  matrix[1] = new int[2] { 5, 6 };           
            //  matrix[2] = new int[3] { 7, 8, 9 };


            //   Console.WriteLine(matrix[0][2]);
            //  Console.WriteLine(matrix[1][0]);
            //  Console.WriteLine(matrix[2][1]);


            //-------------------------TASK-2-------------------------------------------------------


            // int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };


            // int element = matrix[0, 1];
            // for (int i = 0; i < matrix.GetLength(0); i++)
            // {
            // for (int j = 0; j < matrix.GetLength(1); j++)
            // {
            //     Console.Write(matrix[i, j] + " ");
            //  }
            //   Console.WriteLine(); 
            // }


            //---------------------TASK-3----------------------------------------------------------------
            int[,] matrix = new int[,]
    {
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9}
    };

            // Modify the third element in the second row to have a value of 15
            matrix[1, 2] = 15;

            //----------------------------------TASK-4------------------------------------

            object[][] objectMatrix = new object[][]
            {
            new object[] { 42, "Hello", 3.14 },
            new object[] { true, 'A', DateTime.Now }
            };


            for (int i = 0; i < objectMatrix.Length; i++)
            {
                for (int j = 0; j < objectMatrix[i].Length; j++)
                {
                    Type type = objectMatrix[i][j].GetType();
                    Console.WriteLine($"Type: {type}, Value: {objectMatrix[i][j]}");
                }

            }
        }

    }
}