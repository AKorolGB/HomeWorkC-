// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такой позиции нет.
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

int ReleaseMatrix(int[,] matrix, int a,int b)
{
    int result = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           
             
        }
    }
     if (a >matrix.GetLength(0) || b > matrix.GetLength(1))
             Console.WriteLine("такой позиции нет");
             else
             result = matrix[(a-1),(b-1)];
    return result;
    // Console.WriteLine(result);
}


Console.Clear();
Console.Write("Введите размерность массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int [size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine("введите номер строки:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца:");
int b = Convert.ToInt32(Console.ReadLine());
ReleaseMatrix(matrix,a,b);
Console.WriteLine($"Значение: {ReleaseMatrix(matrix,a,b)}");




