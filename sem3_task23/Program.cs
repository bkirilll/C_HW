System.Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
    int cube = i * i * i;
    System.Console.Write($"{cube}, ");
}
