﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// принять трехзначное число
// поделить на 10 чтобы оставить первые две цифры
// взять остаток от деления на 10 и вывести эту цифру

Console.Write("Введите трехзначное число от 100 до 999 включительно:  ");
int num = int.Parse(Console.ReadLine());
if (num>=100 & num<=999)
{
    int num2 = num / 10;
    Console.Write($"Вторая цифра числа {num} -> {num2%10}");
}
else
{
    Console.Write($"{num} не является трехзначным!");
}
