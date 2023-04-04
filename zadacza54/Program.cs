// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
void InputMatrix(int[,] matrix)
{
  for (int i=0; i<matrix.GetLength(0); i++)
  {
    for(int j=0; j<matrix.GetLength(1); j++)
    matrix[i,j] = new Random().Next(10);
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


void NewMatrix(int[,] matrix)
{
   int a = 0;
   int b = 0;
   int n = 1;
   int kont = 0;
    // int  matrix[a,b] = 0;
      for (int i = 0; i < matrix.GetLength(0); i++)
    {
      while(n<matrix.GetLength(1))
      {
         for (int j = n; j < matrix.GetLength(1); j++)
        {
      if (matrix[i,j] > matrix[a,b])
      {
    kont = matrix[i,j];
    matrix[i,j] = matrix[a,b];
    matrix[a,b] = kont;
      }
        }
        n++;
        b++;
      }
     a++;
     n=1;
     b=0;
    } 
}
  

Console.Clear();
Console.Write("Введите размерность массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int [size[0], size[1]];

InputMatrix(matrix);
PrintMatrix(matrix); 
NewMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix); 