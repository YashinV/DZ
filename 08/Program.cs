// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("Введите число a:");
int a = Convert.ToInt32(Console.ReadLine());

for( int i = 0; i <= a; i += 2)
{
Console.Write(i + " ");
 //Console.WriteLine(" число четное ");
}