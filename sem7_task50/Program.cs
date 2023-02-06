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


int[,] FillMatrix(int rows, int cols)
{
    int[,] matr = new int[rows, cols];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matr[i, j] = rand.Next(1, 10);
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

void ElementSearch(int[,] matr, int rows, int cols)
{
    if(rows > matr.GetLength(0) || cols > matr.GetLength(1)) Console.WriteLine($"Такого элемента нет");
    else Console.WriteLine($"Искомый элемент - {matr[rows, cols]}");
}

int[,] matrix = FillMatrix(6, 6);
PrintMatrix(matrix);

int m = InputNumber("Введите номер строки: ");
int n = InputNumber("Введите номер столбца: ");
ElementSearch(matrix, m, n);