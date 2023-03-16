// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
// int n = int.Parse(Console.ReadLine()!);
// int a = 1;
// int b;
// while (a  <= n) {
//       b = a*a*a;
//         Console.WriteLine($"{a}^3 = {b}");
//       a++;     
// }
for (int a = 1; a <= n; a++)
Console.WriteLine($"{a}^3 = {a*a*a}");
