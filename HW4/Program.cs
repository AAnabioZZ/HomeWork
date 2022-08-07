//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//
//3, 5 -> 243 (3⁵)
//
//2, 4 -> 16

int DegreeNum(int num,int deg)
{
    if (deg < 1) return -1;

    int result = num;
    for (int i = 1; i < deg; i++) result = result * num;

    return result;
}

Console.Write("введите натуральное число ");
int x = Convert.ToInt32(Console.ReadLine()); 

Console.Write("и его степерь ");
int y = Convert.ToInt32(Console.ReadLine()); 

Console.Write($"И так: {x} в степени {y} равен {DegreeNum(x,y)}");

/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/
/*
int SumNum(int num)
{
    int result = 0;

    while (num != 0)
    {
        result = result + num % 10;
        num /= 10;
    }
    return result;
}
Console.Write("Введите натуральное число , а мы посчитаем сумму цифр в нем: ");
int x = Convert.ToInt32(Console.ReadLine()); 
Console.Write($"сумма цифв в числе: {x} равена {SumNum(x)}");
*/

/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/
/*
int[] NewArray(int x)
{
    int[] result = new int[x];
    return result;
}
int[] InArray(int[] arr)
{
    for(int i = 0; i< arr.Length; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}
void ShowArray(int[] arr)
{
  
    for(int i = 0; i < arr.Length ; i++ )
        Console.Write($"индекс {i} число {arr[i]}; ");

}
int a = 0;
Console.WriteLine("Cейчас мы вместе создадим массив и заполним его натуральными числами. \nШаг 1. Введите колличество желаемых элементов в массиве (не рекомендуется больше 10 , так как устанене вводить значения ;))");
a = Convert.ToInt32(Console.ReadLine());
int[] array = NewArray(a);

Console.WriteLine("Шаг 2. Последовательно вводите элеманты массива, после каждого элеманата нажимайте кнопку Ввод(Enter) на клавиатуре.");
array = InArray(array);

Console.WriteLine("Вот такой массив у нас получился: ");
ShowArray(array);
*/

