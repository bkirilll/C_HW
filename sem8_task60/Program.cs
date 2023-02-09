int[,,] FillMatrix(int m, int n, int h)
{
    int[,,] matr = new int[m*n*h];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < m; j++)
        {
            for (int k = 0; k < h; k++)
                matr[i, j, k] = rand.Next(10, 100);
        }
    }
    return matr;
}

void PrintMatrix(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}{(i, j, k)} ");
            }
            System.Console.WriteLine();
        }
    }
}

int[,,] cube = FillMatrix(2, 2, 2);
PrintMatrix(cube);