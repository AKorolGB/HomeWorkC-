// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
string s = Convert.ToString(n);
// double k = (double)n;
// while (k.Length>5) {
//     Console.WriteLine("Ошибка!!!1\nВведите пятизначное число: ");
//     n = Convert.ToInt32(Console.ReadLine());
// }
// while (s<5 || s>5) {
//     Console.WriteLine("Ошибка!!!1/nВведите пятизначное число: ");
//     n = Convert.ToInt32(Console.ReadLine());
// }
if (s[0]==s[4] && s[1]==s[3])
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");

