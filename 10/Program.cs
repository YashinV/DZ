// Задача 10: Напишите программу, 
// которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите от 100 до 999 число ");
int a = Convert.ToInt32(Console.ReadLine());
if (a>=100 && a<=999)
{
int DesreaseByTen = a / 10;
int LastDigit = DesreaseByTen  %10;
Console.WriteLine(" Вторая цифра числа = " +LastDigit );
}
else
{
Console.WriteLine("вы ввели не правильное число, повторите попытку 100 -999 : ");
a=Convert.ToInt32(Console.ReadLine());
}
{
int DesreaseByTen = a / 10;
int LastDigit = DesreaseByTen  %10;
Console.WriteLine(" Вторая цифра числа = " +LastDigit );
}