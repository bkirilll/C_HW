System.Console.Write("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day > 0 && day < 6)
{
    System.Console.WriteLine("Этот день не является выходным");
}
else if (day == 6 || day == 7)
{
    System.Console.WriteLine("Этот день является выходным");
}
else
{
    System.Console.WriteLine("Вы не ввели день недели");
}
