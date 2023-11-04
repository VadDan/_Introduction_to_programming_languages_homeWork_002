// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день 
// выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели: ");
string numDay = Console.ReadLine();
if (numDay == "1")
{
    Console.Write("Рабочий день ");
}
else if (numDay == "2")
{
    Console.Write("Рабочий день ");
}
else if (numDay == "3")
{
    Console.Write("Рабочий день ");
}
else if (numDay == "4")
{
    Console.Write("Рабочий день ");
}
else if (numDay == "5")
{
    Console.Write("Рабочий день ");
}
else if (numDay == "6")
{
    Console.Write("Выходной! ");
}
else if (numDay == "7")
{
    Console.Write("Выходной! ");
}
else 
{
    Console.Write("Нет такого дня ");
}

