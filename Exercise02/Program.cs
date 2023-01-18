﻿/***********************/
/*****Te3Ka_PaynE*******/
/*Mnement4813@yandex.ru*/
/***********************/

/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

//Получение числа от пользователя.
Console.WriteLine("Введите любое число. Программа выведет третью цифру справа этого числа, если она есть.");
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

//Если вдруг введено отрицательное число, то мы делаем его положиельным. Это убирает знак "-" при выводе ответа.
number = Math.Abs(number);

//Проверка на то, что у числа больше трёх знаков
if (number < 100)
{
    Console.WriteLine("В числе меньше трёх знаков. Третью цифру невозможно вывести. Выполнение программы прервано.");
    return;
}

//Вывод третьей цифры на экран
//Сначала нужно привести число к трём знакам.
while (number >= 1000)
    number /= 10; //Убираем по одной цифре, пока искомое число не станет трёхзначным
number %= 10; //Получаем последнюю (искомую) цифру в трёхзначном числе
Console.WriteLine("Третья цифра введённого числа = " + number);