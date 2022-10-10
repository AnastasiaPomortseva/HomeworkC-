// Напишите программу,которая принимает на вход два числа , а на выходе определяет какое число больше, а какое меньше

Console.Write("Введите первое число: ");
int a =Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите второе число: ");
int b =Convert.ToInt32(Console.ReadLine());

if (a > b)
{ 
    Console.WriteLine ($"{a} - большее из представленных двух чисел");
}
else 
{
    Console.WriteLine ($"{b} - большее из представленных двух чисел");
}
