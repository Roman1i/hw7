int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];

for (int i = 0; i < m; i++)
{
    Console.WriteLine();
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(1,10);
        Console.Write(matrix[i, j] + " ");
    }
}
Console.WriteLine();
Console.Write("Введите номер строки: ");
int str = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int row = Convert.ToInt32(Console.ReadLine());
while (str > m || row > n )
{
    Console.WriteLine("Такого элемента нет, попробуйте ещё раз.");
    Console.Write("Введите номер строки: ");
    str = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер столбца: ");
    row = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(matrix[str - 1, row - 1]);
