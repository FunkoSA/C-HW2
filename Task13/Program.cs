/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 6

78 -> третьей цифры нет

32679 -> 6

*/
using System;
using static System.Console;

Clear();

Write("Введите число:");
string Number = ReadLine();
int Len = Number.Length;

try
{
    int result = Int32.Parse(Number);
    
    WriteLine (Len > 2 ? $"Третья цифра числа {Number} является {Convert.ToInt32(Number)/100%10}" : $"У введенного числа нет третьей цифры, оно меньше 100");
    WriteLine (Convert.ToInt32(Number)/100 != 0 ? $"Третья цифра числа {Number} является {Convert.ToInt32(Number)/100%10}" : $"У введенного числа нет третьей цифры, оно меньше 100");
}
catch (FormatException)
{
    WriteLine($"Введенное значение '{Number}' не является числом!");
}
