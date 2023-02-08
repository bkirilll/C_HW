int[,] FillMatrix(int rows, int cols)
{
    int[,] matr = new int[rows, cols];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matr[i, j] = rand.Next(0, 10);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int MinSumAmongRows(int[,] matr)
{
    int minSum = 0;
    int numOfRow = 0;
    int tempSum = 0;
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        minSum += matr[0, i];
    }
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++) tempSum += matr[i, j];
        if (tempSum < minSum)
        {
            minSum = tempSum;
            numOfRow = i;
        }
        tempSum = 0;
    }
    return numOfRow;
}




int[,] matrix = FillMatrix(6, 4);
PrintMatrix(matrix);
MinSumAmongRows(matrix);
System.Console.WriteLine($"Строка с наименьшей суммой - {MinSumAmongRows(matrix) + 1}");