// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
void InputMatrix(int[,] matrix)
{
  for (int i=0; i<matrix.GetLength(0); i++)
  {
    for(int j=0; j<matrix.GetLength(1); j++)
    matrix[i,j] = new Random().Next(100);
  }
}

void PrintMatrix(int[,] matrix)
{
  for (int i=0; i<matrix.GetLength(0); i++)
  {
    for (int j=0; j<matrix.GetLength(1); j++)
    Console.Write($"{matrix[i,j]} \t");
    Console.WriteLine();
  }
}

void SredArif(int[,] matrix)
{
    double sum = 0;
    double sred = 0;
    for (int k = 0; k < matrix.GetLength(1); k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
        sum = matrix[i,k ] + sum;
     sred = sum/matrix.GetLength(0);
        }
          
         Console.WriteLine($"среднее арифметическое элементов {k + 1} столбца : {Math.Round(sred,2)}");

         sum =0;
    }
}



Console.Clear();
Console.Write("Введите размерность массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int [size[0], size[1]];

InputMatrix(matrix);
PrintMatrix(matrix); 
SredArif(matrix);
