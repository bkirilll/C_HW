int[,] FillMatrix(int rows, int cols)
{
    int[,] matr = new int[rows, cols];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matr[i, j] = rand.Next(0, 4);
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

int InputNumber(string str)

{
    int number;
    string? text;
    while (true)
    {
        Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Введено не корректное число");
    }
    return number;

}

int[,] MatrixMultiplication(int[,] matr1, int[,] matr2)
{
    int[,] matr3 = new int[matr1.GetLength(0), matr2.GetLength(1)];
    {
        for (int i = 0; i < matr3.GetLength(0); i++)
        {
            for (int j = 0; j < matr3.GetLength(1); j++)
            {
                int tempMatr = 0;
                for (int k = 0; k < matr1.GetLength(1); k++)
                {
                    tempMatr += matr1[i, k] * matr2[k, j];
                }
                matr3[i, j] = tempMatr;
            }
        }
    }
    return matr3;
}

void CheckCondition(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        System.Console.WriteLine("Результирующая матрица: ");
        PrintMatrix(MatrixMultiplication(matrix1, matrix2));
    }
    else System.Console.WriteLine("Количество столбцов 1 матрицы не совпадает с количеством строк 2 матрицы");
}


int col1 = InputNumber("Введите количество строк 1-ой матрицы: ");
int row1 = InputNumber("Введите количество столбцов 1-ой матрицы: ");
int col2 = InputNumber("Введите количество строк 2-ой матрицы: ");
int row2 = InputNumber("Введите количество столбцов 2-ой матрицы: ");
int[,] matrix1 = FillMatrix(col1, row1);
int[,] matrix2 = FillMatrix(col2, row2);
PrintMatrix(matrix1);
System.Console.WriteLine();
PrintMatrix(matrix2);
CheckCondition(matrix1, matrix2);