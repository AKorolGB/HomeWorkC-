// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
void ImputArray(int[] array)
{
  for(int i = 0; i < array.Length; i++)
      array[i]= Convert.ToInt32(Console.ReadLine());
}



int PositiveElements(int[] array)
{
  int PositiveElements = 0;
  for(int i = 0; i < array.Length; i++)
    {
      if (array[i] >= 0)
      PositiveElements = PositiveElements + 1;
    }
    return PositiveElements;
}


Console.Clear();
Console.WriteLine("Введите количествоэлементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
ImputArray(array);
Console.WriteLine($"Заданный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Количество позитивных элементов: {PositiveElements(array)}");

