using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace MatrixTimesMatrix
{
    public static class mtm
    {
        public static int GetNumberOfColumns(double[,] matrix)
        {
            int numberOfColumns = matrix.GetLength(1); ;
            return numberOfColumns;
        }
        public static int GetNumberOfRows(double[,] matrix)
        {
            int numberOfRows = matrix.GetLength(0); ;
            return numberOfRows;
        }
        public static bool CheckForPossibleMultiplication(double[,] matrix1, double[,] matrix2)
        {
            bool isPossible = false;
            if (GetNumberOfColumns(matrix1) == GetNumberOfRows(matrix2))
            {
                isPossible = true;
            }
            return isPossible;
        }
        public static bool CheckForPossibleAdditionOrSubstraction(double[,] matrix1, double[,] matrix2)
        {
            bool isPossible = false;
            if ((GetNumberOfColumns(matrix1) == GetNumberOfColumns(matrix2)) && (GetNumberOfRows(matrix1) == GetNumberOfRows(matrix2)))
            {
                isPossible = true;
            }
            return isPossible;
        }
        public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
        {
            double[,] result;
            if (CheckForPossibleMultiplication(matrix1, matrix2))
            {
                result = new double[GetNumberOfRows(matrix1), GetNumberOfColumns(matrix2)];

                for (int row = 0; row < GetNumberOfRows(matrix1); row++)
                {
                    for (int column = 0; column < GetNumberOfColumns(matrix2); column++)
                    {
                        result[row, column] = 0;
                        for (int n = 0; n < GetNumberOfRows(matrix2); n++)
                        {
                            result[row, column] += (matrix1[row, n] * matrix2[n, column]);
                        }
                    }
                }

                return result;
            }
            else
            {
                throw new Exception("invalid matrix size");
            }
        }
        public static double[,] Multiply(double[,] matrix, double number)
        {
            double[,] result = new double[GetNumberOfRows(matrix), GetNumberOfColumns(matrix)];
            for (int row = 0; row < GetNumberOfRows(matrix); row++)
            {
                for (int column = 0; column < GetNumberOfColumns(matrix); column++)
                {
                    result[row, column] = matrix[row, column] * number;
                }
            }
            return result;
        }
        public static double[,] Add(double[,] matrix1, double[,] matrix2)
        {
            double[,] result;
            if (CheckForPossibleAdditionOrSubstraction(matrix1, matrix2))
            {
                result = new double[GetNumberOfRows(matrix1), GetNumberOfColumns(matrix1)];
                for (int row = 0; row < GetNumberOfRows(matrix1); row++)
                {
                    for (int column = 0; column < GetNumberOfColumns(matrix1); column++)
                    {
                        result[row, column] = matrix1[row, column] + matrix2[row, column];
                    }
                }
                return result;
            }
            else
            {
                throw new Exception("invalid matrix size");
            }
        }
        public static double[,] Substract(double[,] matrix1, double[,] matrix2)
        {
            double[,] result;
            if (CheckForPossibleAdditionOrSubstraction(matrix1, matrix2))
            {
                result = new double[GetNumberOfRows(matrix1), GetNumberOfColumns(matrix1)];
                for (int row = 0; row < GetNumberOfRows(matrix1); row++)
                {
                    for (int column = 0; column < GetNumberOfColumns(matrix1); column++)
                    {
                        result[row, column] = matrix1[row, column] - matrix2[row, column];
                    }
                }
                return result;
            }
            else
            {
                throw new Exception("invalid matrix size");
            }
        }

    }
}