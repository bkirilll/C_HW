double[] arrayNumbers(int size, int leftRange, int rightRange)
{
    double[] arr = new double[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rand.Next(leftRange, rightRange + 1) + rand.NextDouble(), 1);
    }
    return arr;
}

void DifBetweenMinAndMax(double[] arr)
{
    double dif = 0;
    double max = arr[0];
    double min = arr[1];
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max)
        {
            max = arr[i];
        }
        else if(arr[i]< min)
        {
            min = arr[i];
        }
    }
    dif = Math.Round(max - min, 1);
    System.Console.WriteLine(dif);
}

void Print(double[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}


double[] array = arrayNumbers(4, 10, 20);
Print(array);
DifBetweenMinAndMax(array);