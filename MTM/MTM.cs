using System.Security.Cryptography.X509Certificates;

namespace MTM
{
    public class MTM
    {
        static int GetNumberOfColumns(double[,] matrix)
        {
            int numberOfColumns = matrix.GetLength(1); ;
            return numberOfColumns;
        }
        static int GetNumberOfRows(double[,] matrix)
        {
            int numberOfRows = matrix.GetLength(1); ;
            return numberOfRows;
        }
        static double[,] Multiply(double[,] matrix1, double[,] matrix2)
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
        static bool CheckForPossibleMultiplication(double[,] matrix1, double[,] matrix2)
        {
            bool isPossible = false;
            if (GetNumberOfRows(matrix1) == GetNumberOfColumns(matrix2))
            {
                isPossible = true;
            }
            return isPossible;
        }
    }
}