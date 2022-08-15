/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9

double[,] NewArray2D(int sizeY, int sizeX, int min, int max)
{
    double[,] newArray = new Double[sizeY, sizeX];
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
            newArray[i, j] = new Random().Next(min, max + 1) + Math.Round(new Random().NextDouble(), 1);
    }
    return newArray;
}
*/
void ShowArrayInt(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
            Console.Write(array2D[i, j] + "|");

        Console.WriteLine();
    }
}
/*
void ShowArrayDouble(double[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
            Console.Write(array2D[i, j] + "|");

        Console.WriteLine();
    }
}

double[,] array2D = NewArray2D(3, 4, -10, 10);
ShowArrayDouble(array2D);
Console.WriteLine();
/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

string FindInArrayInt(int[,] array, int xAr, int yAr)
{

    if (yAr > array.GetLength(0)) return "Вне массива";
    if (xAr > array.GetLength(1)) return "Вне массива";

    string result = string.Empty;
    return result + array[yAr - 1, xAr - 1];
}
*/
int[,] NewArray2DInt(int sizeY, int sizeX, int min, int max)
{
    int[,] newArray = new int[sizeY, sizeX];
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
            newArray[i, j] = new Random().Next(min, max + 1);
    }
    return newArray;
}
/*
int[,] arrayInt = NewArray2DInt(5, 5, 0, 10);
ShowArrayInt(arrayInt);
Console.Write(@"Введите координаты для поиска
х порядковый номер цифры с лево на право: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("y порядковый номер строки: ");
int y = Convert.ToInt32(Console.ReadLine());
string find = FindInArrayInt(arrayInt, x, y);
Console.WriteLine($"Результат по указанным координатам {find}");

17 -> такого числа в массиве нет

Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
string ArithmeticMeanArr(int[,] array)
{
    string result = string.Empty;
    double ArithmeticMean = 0;

    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
            ArithmeticMean += array[j, i];

        result += Math.Round(ArithmeticMean / array.GetLength(0), 1) + "|";
        ArithmeticMean = 0;
    }
    return result;
}
int[,] arrayIntFoExer52 = NewArray2DInt(4, 3, 0, 10);
ShowArrayInt(arrayIntFoExer52);
Console.Write("Средне арефметическое каждого столбца: ");
Console.WriteLine(ArithmeticMeanArr(arrayIntFoExer52));