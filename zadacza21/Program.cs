// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.WriteLine("Веддите координату Х1: ");
    double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y1: ");
    double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату z1: ");
    double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Веддите координату x2: ");
    double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Веддите координату y2: ");
    double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Веддите координату z2: ");
    double z2 = Convert.ToDouble(Console.ReadLine());

double s = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
Console.WriteLine($"Расстояние между двумя точками равно {Math.Round(s,2)} ");