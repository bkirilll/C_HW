int Metod(int count)
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        Random rand = new Random();
        array[i] = rand.Next(0, 50);
        System.Console.Write($"{array[i]}, ");
    }
    return array[0];
}
Metod(1);
