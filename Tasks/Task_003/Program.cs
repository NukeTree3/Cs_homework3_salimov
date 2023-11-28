// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.
Random rand = new Random();
int len = rand.Next(2, 20);
double max = 0;
double min = 10000;
double[] a = new double[10];

for (int i = 0; i < 10; i++)
{
    a[i] = Math.Round(rand.Next(0, 1000) + rand.NextDouble(), 3);
}
Console.WriteLine(string.Join("     ", a));
max = a[0];
min = a[0];
for (int i = 0; i < 10; i++)
{
    if (max < a[i])
    {
        max = a[i];
    }
    if (min > a[i])
    {
        min = a[i];
    }
}
Console.WriteLine(min + "   " + max);
Console.WriteLine(max-min);