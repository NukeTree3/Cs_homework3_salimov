// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [20,90].
int[] a = new int[10];
int count = 0;
Random rand = new Random();
for (int i = 0; i < 10; i++)
{
    a[i] = rand.Next(0, 101);
}
Console.WriteLine(string.Join(" ", a));

for (int i = 0; i < 10; i++)
{
    if (a[i] > 20 && a[i] < 90)
    {
        count += 1;
    }
}
Console.WriteLine(count);