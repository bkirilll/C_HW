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

int NumberLenght(int len)
{
    for (int i = 0; i > len; i++)
    {
        len = len / 10;
    }
    return len;
}

void NumbersSum(int num, int len)
{
    int sum = 0;
    for(int i = 1; i <= len; i++)
    {
        sum = sum + (num%10);
        num = num /10;
    }
    Console.WriteLine(sum);
}


int number = InputNumber("Введите число: ");
int len = NumberLenght(number);

NumbersSum(number, len);