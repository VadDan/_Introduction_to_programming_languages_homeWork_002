﻿// Задача 13: Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99 && num < 1000)
{
    num = num % 10;
    System.Console.WriteLine(num);
}
else if (num > 999 && num < 10000)
{
    num = num % 100 / 10;
    System.Console.WriteLine(num);
}
else if (num > 9999 && num < 100000)
{
    num = num % 1000 / 100;
    System.Console.WriteLine(num);
}
else if (num > 99999 && num < 1000000)
{
    num = num % 10000 / 1000;
    System.Console.WriteLine(num);
}
else
{
    System.Console.WriteLine("Третьей цифры нет");
}
