int InputNumber(string str)

{
    int number;
    string ?text;
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

double[,] FillMatrix(int rows, int cols)
{
    double[,] matr = new double[rows, cols];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matr[i, j] = Math.Round(rand.Next(-10, 10) + rand.NextDouble(), 1);
        }
    }
    return matr;
}

void PrintMatrix(double[,] matr)
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

int m = InputNumber("Введите количество строк: ");
int n = InputNumber("Введите количество столбцов: ");
System.Console.WriteLine();
double[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);