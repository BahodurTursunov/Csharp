using System;

internal static class ProgramHelpers
{
    private static int[,] GetRandomArr(int rows, int columns)
    {
        Random random = new Random();
        var result = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = random.Next(100);
            }
            return result;

        }
    }
}