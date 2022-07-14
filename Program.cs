﻿//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

void task10()
{
    Console.WriteLine("Данная программа показывает вторую цифру заданного трёхзначного числа.");
    Console.Write("Введите трёхзначное число:");
    int number = Convert.ToInt32(Console.ReadLine());
    int answer = number % 100 / 10;
    Console.WriteLine("Второй цифрой числа " + number + " является " + answer);
    Console.WriteLine(" ");// пустая строка для красоты
}

//Задача 13: Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void task13()
{
    Console.WriteLine("Данная программа выводит третью цифру указанного числа");
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number < 100)
    {
        Console.WriteLine("Третьей цифры у числа " + number + " нет"); //Исключаем слишком короткие числа
    }
    else
    {
        int divider = 100;
        while (number / divider > 0) //узнаём "длинну" числа
        {
            divider *= 10;
        }
        int answer = number / (divider / 1000) % 10;
        Console.Write("Третьей цифрой числа " + number + " является число " + answer);

    }
    Console.WriteLine(" ");// пустая строка для красоты
    Console.WriteLine(" ");// пустая строка для красоты



}

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void task15()
{
    Console.WriteLine("Данная программа выводит день недели, который соответствует заданному числу и сообщает является ли он выходным.");
    string[] week = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
    Console.Write("Введите число от 1 до 7: ");
    int choise = Convert.ToInt32(Console.ReadLine());
    choise--; // уменьшаем введённое число на единицу, чтобы соответствовало индексам массива
    if (choise >= 0 && choise <= 6)
    {
        if (choise == 5 || choise == 6)
        {
            Console.WriteLine(week[choise] + " является выходным днём");
        }
        else
        {
            Console.WriteLine(week[choise] + " не является выходным днём");
        }
        Console.WriteLine(" ");// пустая строка для красоты
    }
    else
    {
        Console.WriteLine("Вы ввели неверное число");
    };
}


//Запуск всех заданий поочерёдно. При меобходимости, любое задание можно закомментировать.
task10();
task13();
task15();