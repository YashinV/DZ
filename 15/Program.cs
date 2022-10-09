// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//  и проверяет, является ли этот день выходным.?
Console.WriteLine("введите число от 1 до 7, где 1 это понедельник");
int a = Convert.ToInt32(Console.ReadLine());
while(a < 0 |a > 7 )
{
    Console.WriteLine("что то пошло не так, введите число от 1 до 7");
    a = Convert.ToInt32(Console.ReadLine());
}
if (a == 6 | a == 7) Console.Write(" Суббота Воскресень");
else Console.WriteLine("не вых" );

// (" Суббота")("Воскресень")