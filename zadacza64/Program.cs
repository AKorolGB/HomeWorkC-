// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

// string f(int n , int a)
// {
//   if (n == a)
//     return $" {a}";
//   return $" {n}" + f(n - 1,a)  ;
// }

string f(int n )
{
  if (n == 1)
    return $" 1";
  return $" {n}" + f(n - 1)  ;
}



Console.Clear();
Console.WriteLine("Введите значение N:");;
int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите значение A :");;
// int a = int.Parse(Console.ReadLine()!);
Console.WriteLine(f(n));
// if (n > a)
// Console.WriteLine(f(n,a));
// else
//   Console.WriteLine(f(a,n));

