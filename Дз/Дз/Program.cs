using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Дз
{
    internal class Program
    {
        static void Main()
        {
            int[,] array = new int[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int[] rowColumnSums = GetRowColumnSums(array);

            Console.WriteLine("Суммы строк и столбцов:");
            for (int i = 0; i < rowColumnSums.Length; i++)
            {
                Console.WriteLine("Элемент {0}: {1}", i, rowColumnSums[i]);
            }
        }

        static int[] GetRowColumnSums(int[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            int[] rowColumnSums = new int[rows + columns];

            for (int i = 0; i < rows; i++)
            {
                int rowSum = 0;
                for (int j = 0; j < columns; j++)
                {
                    rowSum += array[i, j];
                }
                rowColumnSums[i] = rowSum;
            }

            for (int j = 0; j < columns; j++)
            {
                int columnSum = 0;
                for (int i = 0; i < rows; i++)
                {
                    columnSum += array[i, j];
                }
                rowColumnSums[rows + j] = columnSum;
            }

            return rowColumnSums;
        }
    }

}

