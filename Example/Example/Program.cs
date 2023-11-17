using MatrixTimesMatrix;

internal class Program
{
    private static void Main(string[] args)
    {
        double[,] matrix1 = { { 2, 2 }, { 3, 4 } };
        double[,] matrix2 = { { 4, 2 }, { 6, 3 }};
        double[,] result = mtm.Multiply(matrix1, matrix2);
        showMatrx(result);
        result = mtm.Add(matrix1, matrix2);
        showMatrx(result);
        result = mtm.Substract(matrix1, matrix2);
        showMatrx(result);
    }
    public static void showMatrx(double[,] matrix)
    {
        for (int row = 0; row < mtm.GetNumberOfRows(matrix); row++)
        {
            for (int column = 0; column < mtm.GetNumberOfColumns(matrix); column++)
            {
                Console.Write($"{matrix[row, column]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}