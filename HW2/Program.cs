﻿
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int medium(int num)
{
    if (num > 999 || num < 100) return -1;
    return num / 10 % 10;
}
Console.Write("Введите 3х значное число: ");
int UserNum = Convert.ToInt32(Console.ReadLine());
if (medium(UserNum) == -1) Console.Write("Ошибка, вы ввели не 3х значное число");
else Console.Write("Средняя цифра: " + medium(UserNum));
*/
/*
//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int ThirNum(int num)
{
    if (num < 999 ) return -1;
    while (num>999) num = num /10;
    return num % 10;
}
Console.Write("Свас число с меня его 3я цифра: ");
int UserNum = Convert.ToInt32(Console.ReadLine());
if (ThirNum(UserNum) == -1) Console.Write("Ошибка, вы ввели число в котором нет 3ей цифры. ");
else Console.Write("Третья цифра: " + ThirNum(UserNum));
*/

//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
string weekdey(int num)
{
    if (num < 1 || num > 7) return "Ошибка, вы ввели число вне диапозона!";
    if (num > 0 && num < 6) return "Будний день,идем работать.";
    if (num == 6) return "Шабат шалом!;)";
    return "Ура ! Выходной!";
}
Console.Write("Веддите день недели в формате числа от 1 до 7, а мы вам скажем будний этот день или выходной: ");
int UserNumber = Convert.ToInt32(Console.ReadLine());
Console.Write(weekdey(UserNumber));
