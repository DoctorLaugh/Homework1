﻿Console.Clear();
Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine());
if(num1 > num2)
{
    Console.WriteLine("Первое число больше второго");
}
else
{
    Console.WriteLine("Второе число больше первого");
}