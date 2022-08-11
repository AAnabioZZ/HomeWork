//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*
int[] NewUserArray(int size)
{
    int[] newArray = new int[size];
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}
int AboveZero(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 0) result++;
    }
    return result;
}

Console.Write(@"Введите М чисел , а мы скажем сколько из них больше 0! 
Давайте определимся сколько чисел вы хотите ввести ?
: ");
int siz = Convert.ToInt32(Console.ReadLine());
int[] userArray = NewUserArray(siz);
int countAboveZero = AboveZero(userArray);

Console.Write($"Из введеных чисел {countAboveZero} положительных. ");
*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

string LineInter(double a,double b, double aa, double bb)
{
    string result = string.Empty;
    double y = a*((bb-b)/(a-aa))+b;
    return  result = ((bb-b)/(a-aa)) + "," + y;
}

Console.Write("Введите b1: ");
double b1 =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите b2: ");
double b2 =Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine()); 

 Console.Write(LineInter(k1,b1,k2,b2));



