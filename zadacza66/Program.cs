// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int fm(int m,int n)
{
  if (m == n)
    return m;
  return fm(m - 1,n) + m ;
  // sum = (n+1)+sum;
}

int fn(int m, int n)
{
  if (n == m)
    return n
    ;
  return fm(n - 1,m) +n ;
  // sum = (m+1)+sum;
}



Console.Clear();
Console.WriteLine("Введите значение числа M: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение числа N: ");
int n = int.Parse(Console.ReadLine()!);

if (m > n)

  Console.WriteLine(fm(m,n));
else
  Console.WriteLine(fn(m,n));