using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace за_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[,]
{
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int sum = GetMatrixSum(matrix);
            int mainDiagonalSum = GetMainDiagonalSum(matrix);
            int secondaryDiagonalSum = GetSecondaryDiagonalSum(matrix);
            int rowSum = GetRowSum(matrix, 1); // Вычисляем сумму элементов второй строки (индекс 1)

            Console.WriteLine("Сумма элементов матрицы: " + sum);
            Console.WriteLine("Сумма элементов главной диагонали: " + mainDiagonalSum);
            Console.WriteLine("Сумма элементов побочной диагонали: " + secondaryDiagonalSum);
            Console.WriteLine("Сумма элементов второй строки: " + rowSum);
        }

        static int GetMatrixSum(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            int sum = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    sum += matrix[i, j];
                }
            }

            return sum;
        }

        static int GetMainDiagonalSum(int[,] matrix)
        {
            int size = Math.Min(matrix.GetLength(0), matrix.GetLength(1));

            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += matrix[i, i];
            }

            return sum;
        }

        static int GetSecondaryDiagonalSum(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            int sum = 0;

            for (int i = 0; i < rows; i++)
            {
                sum += matrix[i, columns - i - 1];
            }

            return sum;
        }

        static int GetRowSum(int[,] matrix, int rowIndex)
        {
            int columns = matrix.GetLength(1);

            int sum = 0;

            for (int j = 0; j < columns; j++)
            {
                sum += matrix[rowIndex, j];
            }

            return sum;
        }
    }
}