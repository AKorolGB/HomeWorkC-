
Console.Clear();
Console.WriteLine("Введите цифру дня недел:\n1-Понедельник\n2-Вторник\n3-Среда\n4-Четверг\n5-Пятница\n6-Суббота\n7-Воскресенье ");
int n = Convert.ToInt32(Console.ReadLine());
while (n<1 || n>7) {
Console.WriteLine("Ошибка!!!\nВведите цифру дня недел:\n1-Понедельник\n2-Вторник\n3-Среда\n4-Четверг\n5-Пятница\n6-Суббота\n7-Воскресенье ");
n = Convert.ToInt32(Console.ReadLine());
}
if (n == 6 || n == 7)
Console.WriteLine("Выходной день");
else
Console.WriteLine("Будний день");