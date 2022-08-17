int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[m, n];
double x;

for (int i = 0; i < m; i++)
{
    Console.WriteLine();
    for (int j = 0; j < n; j++)
    {
        x = new Random().NextDouble() * 10;
        matrix[i, j] = Math.Round(x, 1);
        Console.Write(matrix[i, j] + "\t");
    }
}
