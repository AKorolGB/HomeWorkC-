// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 11); // [1, 10]
Console.WriteLine($"[{string.Join(", ", array)}]");
	int sum = 0;
	int max = 0;
	foreach(int items in array) 
	{
	  sum +=items;
	  if (items> max)
	  max =items;
	}
	Console.WriteLine($"Максимальное значение массива: {max}");
	Console.WriteLine($"Сумма элементов массива: {sum}");
