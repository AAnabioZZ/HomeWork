//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> ""1, 2, 3, 4, 5""
//M = 4; N = 8. -> ""4, 6, 7, 8""
/*
void AllNatural(int m, int n)
{
    Console.Write($"{m}, ");
    if (m < n) AllNatural(m + 1, n);
}

Console.Write("Input integet namber: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input integet namber: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    int temp = a;
    a = b;
    b = temp;
}
AllNatural(a, b);

*/
//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
int SumNatural(int m, int n)
{

    if (m <= n) return m += SumNatural(m + 1, n);
    return 0;
}

Console.WriteLine(SumNatural(1, 15));


//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 29
double Akkerman(double m, double n)
{
    if (m == 0)
        return n + 1;
    else
      if ((m != 0) && (n == 0))
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}
Console.WriteLine(Akkerman(3, 2));