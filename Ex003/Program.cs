﻿/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
 является ли число чётным (делится ли оно на два без остатка).
 4 -> да
-3 -> нет
7 -> нет */


int userNumber = new int();
Console.WriteLine("Введите число");
userNumber = Convert.ToInt32(Console.ReadLine());
if (userNumber % 2 == 0)
    {
        Console.WriteLine("Да (введено четное число)");
    }
else
    {
    Console.WriteLine("Нет (введено нечетное число)");
    }