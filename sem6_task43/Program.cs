double InputNumber(string str)
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

double b1 = InputNumber("Введите b1 из уравнения y = k1*x + b1: ");
double k1 = InputNumber("Введите k2 из уравнения y = k1*x + b1: ");
double b2 = InputNumber("Введите b2 из уравнения y = k1*x + b1: ");
double k2 = InputNumber("Введите k2 из уравнения y = k1*x + b1: ");

double x = Math.Round((b1 - b2) / (k2 - k1), 2);
double y = Math.Round(k1 * x + b1, 2);

Console.WriteLine($"Прямые пересеутся в точке с координатами ({x}, {y})");