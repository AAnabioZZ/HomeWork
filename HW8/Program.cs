// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.
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
void ShowArrayInt(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
            Console.Write(array2D[i, j] + "|");

        Console.WriteLine();
    }
}

int[,] SortDiscenting(int[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
        for (int j = 0; j < array2d.GetLength(1); j++)
            for (int k = j, temp = 0; k < array2d.GetLength(1); k++)
                if (array2d[i, j] < array2d[i, k])
                {
                    temp = array2d[i, j];
                    array2d[i, j] = array2d[i, k];
                    array2d[i, k] = temp;
                }
    return array2d;
}

Console.Write("Введите колличество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальный элемент: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный элемент: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = NewArray2DInt(m, n, min, max);
ShowArrayInt(array);
Console.WriteLine();
//ShowArrayInt(SortDiscenting(array));

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int MinSumString(int[,] array2d)
{
    int minSum = 0, result = 0, temp = 0;
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        temp = 0;
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            temp += array[i, j];

            if (i == 0) minSum = temp;

            if (temp < minSum)
            {
                minSum = temp;
                result = i;
            }
        }

    }
    return result;
}
Console.WriteLine($"мимальная сумма элементов в строке с индексолм {MinSumString(array)}");

/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49
*/
int[,] ProducktsFoArray(int[,] array1, int[,] array2)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
            array1[i, j] *= array2[i, j];
    }
    return array1;
}
int[,] array2 = NewArray2DInt(m, n, min, max);
ShowArrayInt(array2);
Console.WriteLine();
ShowArrayInt(ProducktsFoArray(array,array2));


//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.
//массив размером 2 x 2 x 2
//12(0,0,0) 22(0,0,1)
//45(1,0,0) 53(1,0,1)



//Задача 62. Заполните спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//1 2 3 4
//12 13 14 5
//11 16 15 6
//10 9 8 7