// Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
int count=Convert.ToInt32(Console.ReadLine());
 if (count%2==0)
 {
    Console.WriteLine("данное число четное");
 }
else
{
    Console.WriteLine("данное число нечетное");
}