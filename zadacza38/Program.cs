// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.03 7.85 22.13 2.05 78.48] -> 76.43

void InputArray(double[] array)
{
  for(int i = 0; i < array.Length; i++)
array[i] = Math.Round(new Random().NextDouble()*(100-0)+0, 2);

} 

// double differencemax(double[] array)
// {
// double max = 0;
//  for(int i = 0; i < array.Length; i++)
//  {
//   if (array[i] > max) 
//   max = array[i];
//  }
//    return max;
// }

double differencemax(double[] array)
{
double max = 0;
 foreach(double items in array)
 {
  if (items > max) 
  max = items;
 }
   return max;
}

// double differencemin(double[] array)
// {
// double min = array[0];
//  for(int i = 0; i < array.Length; i++)
//  {
//   if (array[i] < min) 
//   min = array[i];
//  }
//    return min;
// }

double differencemin(double[] array)
{
double min = array[0];
 foreach(double items in array)
 {
  if (items < min) 
  min = items;
 }
   return min;
}


// ... = new Random.NextDouble() * (end - begin) + begin;
Console.WriteLine("Введите количество элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"Массив: [{string.Join(";  "  ,  array)}]");
Console.WriteLine($"man:{differencemax(array)}");
Console.WriteLine($"min:{differencemin(array)}");
Console.WriteLine($"Разница между максимальным и минимальным элементом:  { Math.Round(differencemax(array) - differencemin(array),2)}");