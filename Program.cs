/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8 
918 -> 1 */

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    Console.WriteLine((number%100-number%10)/10);
}
else Console.WriteLine("Введено не трехзначное число");

 
/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */ 

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int remainder = number;
int Digit = 0;
if (remainder < 0)
{
remainder = - remainder;
}
while (remainder > 999)
{ 
    remainder = remainder/10;
}
if (remainder >=100)
{
    Digit = remainder % 10;
    Console.WriteLine(Digit);
}
else Console.WriteLine("третьей цифры нет"); 

 
/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да 
7 -> да 
1 -> нет*/

Console.WriteLine("Введите цифру от 1 до 7, обозначающую день недели: ");
int weekDay = Convert.ToInt16(Console.ReadLine());
if (weekDay > 0 && weekDay > 5 && weekDay < 8)
{
    Console.WriteLine("да");
}
else if (weekDay > 0 && weekDay < 6)
{
    Console.WriteLine("нет");
}
else Console.WriteLine("Цифра не входит в пределы от 1 до 7");