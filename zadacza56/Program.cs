// Задача 56: Задайте прямоугольный двумерный массив.
//  Напишите программу, которая будет находить строку с наименьшей суммой элементов.


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

void MinSum(int[,] matrix)
{
  int sum = 0;
  int minsum = 0;
  // int n = 0;
  // while(n < matrix.GetLength(0) )
   for (int i=0; i<matrix.GetLength(0); i++)
  {
    for(int j=0; j<matrix.GetLength(1); j++)
    sum = matrix[i,j] + sum;
    
    if (sum < minsum || minsum == 0)
        minsum = sum;
       
         Console.WriteLine($"Сумма элементов строки {i}: {sum}");
  sum = 0; 
  } 
   Console.WriteLine($"Минимальная сумма элементовстроки: {minsum}");
  
 
}



Console.Clear();
Console.Write("Введите размерность массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int [size[0], size[1]];

InputMatrix(matrix);
PrintMatrix(matrix); 
MinSum(matrix);