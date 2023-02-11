int Sum(int M, int N)
{
    if (M == 0) return (N * (N + 1)) / 2;           
    else if (N == 0) return (M * (M + 1)) / 2;       
    else if (M == N) return M;                      
    else if (M < N) return N + Sum(M, N - 1); 
    else return N + Sum(M, N + 1);
}

System.Console.WriteLine(Sum(4, 8));