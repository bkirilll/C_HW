System.Console.Write("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99)
{
    while (num > 999)
    {
        num = num / 10;
    }
    System.Console.Write($"Третья цифра = {num % 10}");
}
else
{
    System.Console.WriteLine("Третьей цифры нет");
}