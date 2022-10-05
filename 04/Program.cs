// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if(b > a) max = b;
if(b > c) max = c;
Console.WriteLine(max);

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
