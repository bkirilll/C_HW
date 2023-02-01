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

int a = InputNumber("Введите число А: ");
int b = InputNumber("Введите число Б: ");

void Exponentiation(int a, int b)
{
    int answer = 1;
    for (int i = 1; i <= b; i++)
    {
        answer = answer * a;
    }
    System.Console.WriteLine(answer);

}

Exponentiation(a, b);


