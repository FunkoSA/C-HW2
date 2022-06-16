/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

using System;
using static System.Console;

Clear();
WriteLine("Программ принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
Write("Введите трехзначное число:");
string Number = ReadLine();
while (Number.Length != 3)
{
    Write("Введите трехзначное число:");
    Number = ReadLine();
   
}

try
{
    int result = Int32.Parse(Number);
    WriteLine ($"Вторая цифра числа {Number} является {Convert.ToInt32(Number)/10%10}");
}
catch (FormatException)
{
    WriteLine($"Введенное значение '{Number}' не является числом!");
}
