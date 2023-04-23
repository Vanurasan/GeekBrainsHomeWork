
int Numbers(int m, int n)
{
    if (m == 0) { return (n + 1); }
    else if ((m > 0) && (n == 0)) { return(Numbers(m - 1, 1)); }
    else { return(Numbers(m - 1, Numbers(m,n-1))); }
}
Console.Write("M=");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("N=");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Numbers(M, N));