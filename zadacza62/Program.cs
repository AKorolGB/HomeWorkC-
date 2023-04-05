
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
void PrintMatrix(int[,] matrix)
{
  for (int i=0; i<matrix.GetLength(0); i++)
  {
    for (int j=0; j<matrix.GetLength(1); j++)
    Console.Write($"{matrix[i,j]} \t");
    Console.WriteLine();
  }
}

void Spiral(int[,] matrix)
{
int i = 0;
int j = 0;
int znacz =1;

while (znacz <= matrix.GetLength(0) * matrix.GetLength(1))
{
  matrix[i, j] = znacz;
  znacz++;
  if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= matrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > matrix.GetLength(1) - 1)
    j--;
  else
    i--;
}
}

Console.Clear();
Console.Write("Введите размерность массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int [size[0], size[1]];


Spiral(matrix); 
PrintMatrix(matrix);










