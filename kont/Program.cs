void ImputArray(string[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write($"Введите {i+1} элемент массива: ");
  array[i]= Console.ReadLine();
}
}


int longbArray(string[] array)
{
int longb = 0;
for (int i = 0; i < array.Length; i++)
if (array[i].Length <= 3){
// b[sum] = a[i];
longb =longb +1;
}
   return longb;
}

void newArray(string[] array)
{
int longb = 0; 
string[] barray = new string[longb];
for (int i = 0; i < array.Length; i++)
{
if (array[i].Length <= 3)
{
longb =longb +1;
}
}
int f = 0;
for (int i = 0; i < array.Length; i++)
if (array[i].Length <= 3)
{
barray[f] = array[i];
f = f +1;
}
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];
int longb = 0; 
// for (int i = 0; i < array.Length; i++){
// Console.Write($"Введите {i+1} элемент массива: ");
//   a[i]= Console.ReadLine();
// }
ImputArray(array);
longbArray(array);
Console.WriteLine(longbArray(array));
// string[] barray = new string[longb];
newArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Новый  массив: [{string.Join(", ", newArray(array))}]");
