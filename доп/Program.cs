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
int tmp;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m/2; j++)
    {
        tmp = matrix[j, i];
        matrix[j, i] = matrix[m - j - 1, i];
        matrix[m - j - 1, i] = tmp;
    }

}

for (int i = 0; i < m; i++)
{
    Console.WriteLine();
    for (int j = 0; j < n; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
}


