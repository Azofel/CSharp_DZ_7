Console.Write("Введите размерность m массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность n массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] randomArray = new double[m,n];

void array(int m, int n)
{
    int i, j;
    Random chaotic = new Random();
    for (i = 0; i < m; i++)
    {
        Console.WriteLine();
        for (j = 0; j < n; j++)
            {
                randomArray[i,j] = chaotic.NextDouble();
                Console.Write($"{randomArray[i,j]:f} ");
            }
    }
}

array(m,n);