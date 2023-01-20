System.Console.Write("Введите пятизначное число: ");
string? abcde = Console.ReadLine();
if (abcde!.Length == 5)
{
    if (abcde[0] == abcde[4] && abcde[1] == abcde[3])
    {
        System.Console.Write($"Число {abcde} является палиндромом");
    }
    else
    {
        System.Console.Write($"Число {abcde} не является палиндромом");
    }
}
else
{
    System.Console.WriteLine("Вы ввели не пятизначное число");
}