// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//например 2, 3, 7 -> 7, 44 5 78 -> 78, 22 3 9 -> 22;

Console.Write ("Введите первое число: ");
int a =Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите второе число: ");
int b =Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите третье число: ");
int d =Convert.ToInt32(Console.ReadLine());
int max = a;

if(a>b)
{
    max=a;
    }
if (b>a)
{
    max=b;
    }
if(max>d)
{
    Console.WriteLine(max + " большее число");
}


if(d>=max)
{ 
    max=d;
    Console.WriteLine(d + " большее число");
}