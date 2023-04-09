// Напишите программу, которая будет выдавать название дня недели по заданному номеру
 Console.WriteLine("Введите день недели(число) ");
 int day_n = int.Parse(Console.ReadLine());

 if (day_n == 1)
{
   Console.WriteLine("Понедельник"); 
} 
if (day_n == 2)
{
   Console.WriteLine("Вторник");
} 
if (day_n == 3)
{
   Console.WriteLine("Среда"); 
} 
if (day_n == 4)
{
   Console.WriteLine("Четверг"); 
} 
if (day_n == 5)
{
   Console.WriteLine("Пятница"); 
} 
if (day_n == 6)
{
   Console.WriteLine("Суббота"); 
} 
if (day_n == 7)
{
   Console.WriteLine("Воскресенье"); 
} 
if (day_n >7)
{
   Console.WriteLine("Такого дня недели нет"); 
} 

//Сокращенно это можно записать еще так:
//Console.WriteLine("Введите день недели(число) ");
//int day_n = int.Parse(Console.ReadLine());
// if (day_n == 1) Console.WriteLine("Понедельник"); 
//if (day_n == 2) Console.WriteLine("Вторник");
//if (day_n == 3) Console.WriteLine("Среда"); 
//if (day_n == 4) Console.WriteLine("Четверг"); 
//if (day_n == 5) Console.WriteLine("Пятница"); 
//if (day_n == 6) Console.WriteLine("Суббота"); 
// if (day_n == 7)Console.WriteLine("Воскресенье"); 
//if (day_n >7) Console.WriteLine("Такого дня недели нет"); 
