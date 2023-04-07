// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int  A(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return A(n - 1, 1);
    else
      return A(n - 1, A(n, m - 1));
}


Console.Clear();
Console.WriteLine("Введите значение числа M: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение числа N: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine( A(m,n));