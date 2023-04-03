// //  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// void InputMatrix(int[,] matrix)
// {
//   for(int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for(int j = 0; i < matrix.GetLength(1); j++)
//     matrix[i,j]= new Random().Next(0,10);
//   }
// }
// //  matrix[i,j]= Math.Round(new Random().NextDouble(), 2);
// void PrintMatrix(int[,] matrix)
// {
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for(int j=0; j < matrix.GetLength(1); j++)
// Console.Write($"{matrix[i,j]} \t" );
//     Console.WriteLine();
//   }
// }



// Console.Clear();
// Console.Write("Введите размерность массива: ");
// // int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
// int[] size = Console.ReadLine()!.Split().Select( x=> int.Parse(x)).ToArray();
// int[,]matrix =new int[size[0], size[1]];
// InputMatrix(matrix);
// PrintMatrix(matrix);


void InputMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().NextDouble()*(10-(-10))+(-10); // [-10, 10]
    }
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{Math.Round(matrix[i, j],2)} \t");
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размерность массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
double[,] matrix = new double[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);