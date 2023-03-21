// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("Введите  число: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = 0;
int b = 0;
while ( n > 0 ) {
   a = n%10;
   b = b+a;
   n = n/10;

}
    Console.WriteLine($"Cумму цифр в числе: {b}");  