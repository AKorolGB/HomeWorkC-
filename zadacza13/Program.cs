Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n/100>=10)
{
    n= n/10;
}
if (n/100 < 1)
    Console.WriteLine("Третей цифры нет");
else if (n/100 < 10)
  Console.WriteLine(n % 10);

// Console.Clear();
// Console.WriteLine("введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// string s = Convert.ToString(n);
// if (n/100 < 1  )
// Console.WriteLine("третей цифры нет");
// else
// Console.WriteLine(s[2]);