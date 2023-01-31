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

void SumOfOddNumbers(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum = sum + arr[i];
    }
    System.Console.WriteLine(sum);
}

void Print(int[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}



int[] array = arrayNumbers(4, -20, 20);
Print(array);
SumOfOddNumbers(array);
