//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] NewArray(int size, int min, int max)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(min, max);

    return array;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]}, ");
    Console.WriteLine();
}
int EvenSize(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) result++;

    return result;
}
int SumOnOdd(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
        if (i % 2 != 0) result += array[i];

    return result;
}
int Diff(int[] array)
{
    int max = array[0], min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    return max - min;
}

int[] array = NewArray(10, 100, 1000);
ShowArray(array);
Console.WriteLine($"Количество четных в данном массиве навняется: {EvenSize(array)}");

array = NewArray(10, 1, 101);
ShowArray(array);
Console.WriteLine($"Сумма элементов с нечетными индексом: {SumOnOdd(array)}");

Console.WriteLine($"Разница между самым большим и самым мальниким элементом массива: {Diff(array)}");
