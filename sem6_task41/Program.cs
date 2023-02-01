int[] StrToNum(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            count++;
        }
    }

    int[] num = new int[count];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";

        while (input[i] != ',')
        {
            if (i != input.Length - 1)
            {
                temp += input[i].ToString();
                i++;
            }
            else
            {
                temp += input[i].ToString();
                break;
            }
        }
        num[index] = Convert.ToInt32(temp);
        index++;
    }
    return num;
}

void Print(int[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

void SumOfPosNumbers(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            sum++;
        }
    }
    System.Console.WriteLine($"Количество элементов больше нуля = {sum}");
}

Console.Write("Введите числа через запятую: ");
int[] numbers = StrToNum(Console.ReadLine());
Print(numbers);
SumOfPosNumbers(numbers);
