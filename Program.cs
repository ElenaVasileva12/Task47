//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//m = 3, n = 4.
//0,5     7    -2   -0,2
//  1  -3,3     8   -9,9
//  8   7,8  -7,1      9

//массив с случайным вводом  двумерный (универсальный) double
double[,] CreateMatrixRndDouble(int rows, int colums, int min, int max, int round = 1)
{
    double[,] matrix = new double[rows,colums];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)  
    {
        for (int j=0;j<matrix.GetLength(1); j++)    
        {
            double num = rnd.NextDouble() * (max - min) + min;
            matrix[i,j] = Math.Round(num, round);
        }
    }
    return matrix;
}

//вывод на экран double двумерный (универсальный)
void PrintMatrixDouble(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)  
    {
        for (int j=0;j<matrix.GetLength(1); j++)    
        {
            Console.Write ($"{matrix[i,j], 6}");
        }
    Console.WriteLine();
    }
}


double[,] array = CreateMatrixRndDouble(3, 4, -10,10);
PrintMatrixDouble(array);

