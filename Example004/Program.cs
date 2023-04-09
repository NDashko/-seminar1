//Напишите программу, которая на вход принимает одно целое число N, а на выходе показывает все целые числа в промежутке от -N до N.
Console.WriteLine("Введите число ");
int a = int.Parse(Console.ReadLine());
for (int i = -a; i<=a;  i++)
{
    System.Console.WriteLine(i);
}