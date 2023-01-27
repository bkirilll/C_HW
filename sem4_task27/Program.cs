int InputNumber(string str)

{
    int number;
    string text;
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

int NumberLen(int a)
{
    int index = 0;
    while (a > 0)
    {
        a = a / 10;
        index++;
    }
    return index;
}

void Sum(int num, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum = sum + (num % 10);
        num = num / 10;
    }
    Console.WriteLine(sum);
}

int num = InputNumber("Введите число: ");
int len = NumberLen(num);

Sum(num, len);