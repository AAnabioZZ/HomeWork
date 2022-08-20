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
    Console.WriteLine();
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

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.

int[,] array = NewArray2DInt(m, n, min, max);
ShowArrayInt(array);
Console.WriteLine();
ShowArrayInt(SortDiscenting(array));

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int MinSumString(int[,] array2d)
{
    int minSum = array2d[0, 0] + array2d[0, 1] * array2d.GetLength(0);
    int result = 0, temp = 0;
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        if (i != 0)
        {
            if (temp < minSum)
            {
                minSum = temp;
                result = i;
            }
        }
        temp = 0;
        for (int j = 0; j < array2d.GetLength(1); j++)
            temp += array2d[i, j];
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
        for (int j = 0; j < array1.GetLength(1); j++)
            array1[i, j] *= array2[i, j];
    return array1;
}
int[,] array2 = NewArray2DInt(m, n, min, max);
ShowArrayInt(array2);

ShowArrayInt(ProducktsFoArray(array, array2));
//Console.Clear();

//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.
//массив размером 2 x 2 x 2
//12(0,0,0) 22(0,0,1)
//45(1,0,0) 53(1,0,1)
int[,,] NewArray3DInt(int sizeY, int sizeX, int sizeZ, int min, int max)
{
    int[,,] newArray = new int[sizeY, sizeX, sizeZ];
    for (int i = 0; i < newArray.GetLength(0); i++)
        for (int j = 0; j < newArray.GetLength(1); j++)
            for (int n = 0; n < newArray.GetLength(2); n++)
            {
                newArray[i, j, n] = new Random().Next(min, max + 1);
                for (int k = i; k >= 0; k--)
                    for (int l = j; l >= 0; l--)
                        for (int m = n - 1; m >= 0; m--)
                            if (newArray[i, j, n] == newArray[k, l, m])
                            {
                                newArray[i, j, n] = new Random().Next(min, max + 1);
                                k = i; l = j; m = n;
                            }

            }
    return newArray;
}
void ShowArrayInt3d(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
            for (int n = 0; n < array3D.GetLength(2); n++)
                Console.Write($"{array3D[i, j, n]}({i},{j},{n}) ");

        Console.WriteLine();
    }

}

int[,,] array3d = NewArray3DInt(6, 6, 6, 10, 99);

ShowArrayInt3d(array3d);

void Show3d(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int k = array3D.GetLength(2) - 1; k >= 0; k--)
        {
            if (k==0) Console.ForegroundColor = ConsoleColor.Red;
            if (k==1) Console.ForegroundColor = ConsoleColor.Yellow;
            if (k==2) Console.ForegroundColor = ConsoleColor.Green;
            if (k==3) Console.ForegroundColor = ConsoleColor.Blue;
            if (k==4) Console.ForegroundColor = ConsoleColor.Cyan;
            if (k==5) Console.ForegroundColor = ConsoleColor.Magenta;
            for (int n = 0; n <= k * 2; n++) Console.Write(" ");
            for (int j = 0; j < array3D.GetLength(1); j++)
            {
                Console.Write(array3D[i, j, k] + "  ");
            }
            
            Console.WriteLine();
           
        }
        Console.WriteLine();
        
    }
    Console.ResetColor();
}
Show3d(array3d);

//Задача 62. Заполните спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//1 2 3 4
//12 13 14 5
//11 16 15 6
//10 9 8 7
int[,] SpiralArray(int rank, int colum)
{
    int[,] array = new int[rank, colum];
    for (int i = 0, j = 0, k = 0, l = 1; array[i, j] == 0; k++)
    {
        while (j < colum - k)
        {
            if (array[i, j] == 0) array[i, j] = l; l++; j++;
        }
        j--; i++;
        while (i < rank - k)
        {
            if (array[i, j] == 0) array[i, j] = l; l++; i++;
        }
        j--; i--;
        while (j >= 0 + k)
        {
            if (array[i, j] == 0) array[i, j] = l; l++; j--;
        }
        j++; i--;
        while (i > 0 + k)
        {
            if (array[i, j] == 0) array[i, j] = l; l++; i--;
        }
        j++; i++;
    }
    return array;
}
ShowArrayInt(SpiralArray(6,6));

