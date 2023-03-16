// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
string s = Convert.ToString(n);
double k = (double)n/10000;
while (k<1 || k>10) {
    Console.WriteLine("Ошибка!!!\nВведите пятизначное число: ");
    n = Convert.ToInt32(Console.ReadLine());
    s = Convert.ToString(n);
    k = n/10000;
}
if (s[0]==s[4] && s[1]==s[3])
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");

