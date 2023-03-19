// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Нельзя использовать функцию Math.Pow()!
// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Clear();
Console.WriteLine("Введите число а: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
int i = 1;
int c = a;
// while (i < b) {
//     c = c * a;
//     i++;
// }
for (c = a; i<b; i++)
       c= c*a;
Console.WriteLine(c);


