// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
 
 void ImputArray(int[] array)
 {
  for(int i = 0; i < array.Length; i++)
  array[i] = new Random().Next(10);
 }

 int SumElem(int[] array)
 {
      int sum = 0;
      for(int i = 0; i < array.Length; i++)
      {
        if( i %2 != 0)
        sum += array[i];
      }
      return sum;
 }
 Console.WriteLine("Введите количество элементов вмассиве: ");
 int n = Convert.ToInt32(Console.ReadLine());
 int[] array = new int[n];
 ImputArray(array);
 Console.WriteLine(string.Join(",", array));
  Console.WriteLine($"сумму элементов, стоящих на нечётных позициях: {SumElem(array)}");