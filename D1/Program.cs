﻿//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

int a, b;
Console.WriteLine("Введите первое число:");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
b = Convert.ToInt32(Console.ReadLine());
if (a > b)
Console.WriteLine("Первое число больше второго");
else if (a < b)
Console.WriteLine("Второе число больше первого");
else

Console.ReadKey();
