// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2-ое число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// if (a > b)
//     Console.WriteLine($"max {a}");
// else
//     Console.WriteLine($"max {b}");

Console.Clear();

Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];
for (int i = 0; i < array.Length; i++){
Console.Write($"Введите {i+1} элемент массива: ");
  a[i]= Console.ReadLine();
}


// string[] a = {"1234", "fsd", "sfds", "d", "wq"};                   
int sum = 0;
int f = 0;
// string[] b = new string[a.Length];
for (int i = 0; i < array.Length; i++)
if (array[i].Length <= 3){
// b[sum] = a[i];
sum = sum +1;
}
string[] barray = new string[sum];    
for (int i = 0; i < array.Length; i++)
if (array[i].Length <= 3){
barray[f] = array[i];
f = f +1;
}

Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Новый  массив: [{string.Join(", ", barray)}]");
// b[0] = b[0] + 10;
// Console.WriteLine(string.Join(" ", a));
// Console.WriteLine(string.Join(" ", b));
Console.WriteLine(sum);
// Console.Clear();
// string s = Console.ReadLine()!;
// int sum = 0;
// // Напишите программу, которая будет находить сумму цифр числа
// for (int i = 0; i < s.Length; i++)
//     sum = sum + int.Parse(s[i].ToString());
// Console.WriteLine(sum);