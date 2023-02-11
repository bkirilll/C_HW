int AckermannFunction(int m, int n)
{
    if (m == 0) return n + 1;
    if(m > 0 && n ==0) return AckermannFunction(m-1, 1);
    if(m > 0 && n > 0) return AckermannFunction(m-1, AckermannFunction(m, n-1));
    return 0;
}

int N = AckermannFunction(3, 2);
Console.WriteLine($"Ackermann(m,n) = {N}");