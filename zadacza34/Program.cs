// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

void ImputArray(int[] array)
{
  for(int i = 0; i < array.Length; i++)
      array[i]= new Random().Next(100,1000);
}

int SumEven(int[] array)
{
  int sum = 0;  
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] % 2 == 0 )
    sum ++;
  }
  return sum;
}

Console.WriteLine("Введите количествоэлементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
ImputArray(array);
Console.WriteLine($"Заданный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"количество чётных чисел в массиве: {SumEven(array)}");
