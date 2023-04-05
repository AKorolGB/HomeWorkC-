// .Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив,
//  добавляя индексы каждого элемента.
void ImputMatrix (int[,,] matrix)
{
  
    for(int x = 0; x< matrix.GetLength(0); x++)
    {
      for (int y =0; y<matrix.GetLength(1); y++)
        {
          for (int z = 0; z<matrix.GetLength(2); z++)
         
          matrix[x,y,z] = new Random().Next(10,100) ;
        }
  
    }
}

void PrintMatrix(int[,,] matrix)
{
    for(int x = 0; x< matrix.GetLength(0); x++)
    {
      for (int y =0; y<matrix.GetLength(1); y++)
        {
          for (int z = 0; z< matrix.GetLength(2); z++)
         Console.Write($"{matrix[x,y,z]} ({x}{y}{z}) \t");
         Console.WriteLine();
        }
  
    }
}





Console.Clear();
Console.Write("ввведите размерность массива:");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();

int[,,] matrix = new int[size[0], size[1], size[2]];

ImputMatrix(matrix);
PrintMatrix(matrix);