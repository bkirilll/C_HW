int[] arrayNumbers(int size, int leftRange, int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

void ParityCheck(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    System.Console.WriteLine($"Количество четных чисел = {count}");
}

void Print(int[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}


int[] array = arrayNumbers(4, 100, 999);
Print(array);
ParityCheck(array);