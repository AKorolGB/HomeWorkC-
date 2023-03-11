Console.Clear();
Console.Write("Введите 1-ое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3-ое число: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b && a > c) 
  Console.WriteLine($"max {a}");
else if (b > a && b > c) 
  Console.WriteLine($"max {b}");
else if  (c > a && c > b) 
   Console.WriteLine($"max {c}");

