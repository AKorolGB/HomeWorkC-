
Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n<100 || n>1000)
{
Console.WriteLine("Ошибка!!\nВведите трехзначное число: ");
n = Convert.ToInt32(Console.ReadLine());
}
int m = n%100;
int s = m/10;
Console.WriteLine(s);


