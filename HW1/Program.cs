/*
//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.WriteLine("Сейчас мы угодаем какое из введенных вами чисе больше)) приступим->");

Console.Write("число а = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("число b = ");
int b = Convert.ToInt32(Console.ReadLine());

if(a>b) Console.Write(a + " больше чем " + b);
if(a<b) Console.Write(b + " больше чем " + a);
*/


/*
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.WriteLine("Сайчас я попрошу вас ввести 3  чесла :");

Console.Write("число а = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("число b = ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("число с = ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b && a > c ) Console.Write("Самое большое из введенных чисел а = " + a);
if (b > a && b > c ) Console.Write("Самое большое из введенных чисел b = " + b);
if (c > b && c > a ) Console.Write("Самое большое из введенных чисел c = " + c);
*/


/*
//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Clear();
Console.WriteLine("Игра чет не чет! Ты загадываешь я отгадываю, начнем!");
Console.Write("вводи загаданное число = ");

int a = Convert.ToInt32(Console.ReadLine());

if(a%2==0) Console.Write("Четное!");
else Console.Write("Не четное!");
*/

/*
//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.WriteLine("привет , давай ты мне число а я тебе все четные до него! начнем ");
Console.Write("твое число: ");

int nam = Convert.ToInt32(Console.ReadLine());
int count = 2;

if(nam > 2){
    Console.Write("Четные числа: ");
    while (nam >= count) 
    {
        Console.Write(count + "; ");
        count = count + 2; 
    }}
else Console.Write("нет четных чисел в выбраном диапазоне");
*/