//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
bool Pal(int num)
{
    if (num / 10000 == num % 10 && num / 1000 % 10 == num % 100 / 10) return true;
    else return false;
}

Console.Write("Введите 5ти значное число, а мы проверим палиндром ли это: ");
int userNum = Convert.ToInt32(Console.ReadLine());
if (Pal(userNum) == true) Console.WriteLine($"{userNum} - палиндром");
else Console.WriteLine($"{userNum} - не палиндром");
 */

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Cor3d(int xa, int ya, int za, int xb, int yb, int zb)
{
    return Math.Sqrt((yb - ya) * (yb - ya) + (xb - xa) * (xb - xa) + (zb - za) * (zb - za));

}

Console.Write("Введите координаты точек в 3д простарнстве. \nВначате точка А нужны координаты x,y,z.\nВедите x : ");
int usXA = Convert.ToInt32(Console.ReadLine());
Console.Write("точка А введите y : ");
int usYA = Convert.ToInt32(Console.ReadLine());
Console.Write("точка А введите z : ");
int usZA = Convert.ToInt32(Console.ReadLine());
Console.Write("Теперь точка B введите x : ");
int usXB = Convert.ToInt32(Console.ReadLine());
Console.Write("точка B введите y : ");
int usYB = Convert.ToInt32(Console.ReadLine());
Console.Write("точка B введите z : ");
int usZB = Convert.ToInt32(Console.ReadLine());

Console.Write($"Расстояние между точками A и B в 3х мерном пространствет составляет: {Cor3d(usXA, usYA, usZA, usXB, usYB, usZB)}");
*/

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

string CoubeN(int N)
{
    string coube = "-> ";
    for (int i = 2; i <= N; i++)
    {
        int a = i * i * i;
        coube = coube + $"{a} ";
    }
    return coube;
}

Console.Write("Введите число больше 2х, а мы покажем кубы от 2х до вашего число: ");
int userNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"кубы {CoubeN(userNum)}");