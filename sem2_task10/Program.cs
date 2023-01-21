System.Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 && num < 1000)
{
    System.Console.WriteLine($"Вторая цифра числа {num} = {(num / 10) % 10} ");
}
else
{
    System.Console.WriteLine("Вы ввели не трехзначное число");
}
