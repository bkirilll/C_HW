int[,] FillMatrix(int rows, int cols)
{
    int[,] matr = new int[rows, cols];
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= rows * cols)
    {
        matr[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < matr.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= matr.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > matr.GetLength(1) - 1)
            j--;
        else
            i--;
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

int[,] matrix = FillMatrix(4, 4);
PrintMatrix(matrix);