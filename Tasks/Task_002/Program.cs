// Задача 2: Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.
int[] a = new int[10];
int count = 0;
Random rand = new Random();
for (int i = 0; i < 10; i++)
{
    a[i] = rand.Next(0, 10000);
}
Console.WriteLine(string.Join(" ", a));

for (int i = 0; i < 10; i++)
{
    if (a[i]%2==0)
    {
        count += 1;
    }
}
Console.WriteLine(count);