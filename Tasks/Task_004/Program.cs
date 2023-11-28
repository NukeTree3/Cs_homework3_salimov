// Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа. 
// Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. Размер массива должен быть равен количеству цифр.
int num = new Random().Next(1, 100000);
int len = Convert.ToString(num).Length;
int[] a = new int[len];
Console.WriteLine(num);
// Console.WriteLine(len);
for (int i = 0; i <= len-1; i++)
{
    a[(len-1)-i] = num % 10;
    num = num / 10;
    // Console.WriteLine((len-1)-i);
    // Console.WriteLine(i);
    // Console.WriteLine(string.Join("     ", a));
    // Console.WriteLine(num);
}
Console.WriteLine(string.Join("     ", a));