// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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

void Proizved(int[,] matrix,int[,] matrix1,int[,] matrix2)
{
int proiz = 0;
  for (int i=0; i<matrix2.GetLength(0); i++)
  {
    for(int j=0; j<matrix2.GetLength(1); j++)
  { 
      for (int x = 0; x < matrix.GetLength(1); x++)
      {
        proiz += matrix[i,x] * matrix1[x,j];
      }
      matrix2[i,j] = proiz ;
  }
  }


}



Console.Clear();
Console.Write("Введите размерность 1 массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int [size[0], size[1]];
Console.Write("Введите размерность 2 массива: ");
int[] size1 = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix1 = new int [size1[0], size1[1]];
// Умножить две матрицы можно только в том случае, если число столбцов первой (m) равняется числу строк второй (n).
while (size[1] != size1[0] )
{
Console.WriteLine("Умнажение невозможно повторите ввод");
Console.Write("Введите размерность 1 массива: ");
size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
 matrix = new int [size[0], size[1]];
Console.Write("Введите размерность 2 массива: ");
 size1 = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
 matrix1 = new int [size1[0], size1[1]];
}
int[,] matrix2 = new int [size[0], size1[1]];

InputMatrix(matrix);
PrintMatrix(matrix); 
Console.WriteLine();
InputMatrix(matrix1);
PrintMatrix(matrix1); 
Proizved(matrix,matrix1,matrix2);
Console.WriteLine();
PrintMatrix(matrix2);