int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
for (int i = 0; i < m; i++)
{
    Console.WriteLine();
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(1, 10);
        Console.Write(matrix[i, j] + " ");
    }
}
Console.WriteLine();
double x;
double[] results = new double[n];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        results[i] += matrix[j, i];
    }
    x = results[i] / m; 
    results[i] = Math.Round(x, 2);
}
Console.WriteLine("Среднее арифметическое каждого столбца: " + string.Join("; ", results) + ".");