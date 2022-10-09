// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//  что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
string a_text = Convert.ToString(a);
if(a_text.Length > 2)
{
    Console.WriteLine("Третья цифра : " + a_text[0]);
}
else
{
    Console.WriteLine("Третьей цифры нет");

}
//     (a>=99);
// Console.Write("Третьей цифры нет, число двухзначное"+Convert.ToSring(a%100));
//     (a<=100);
//     Console.Write("Третья цифра : "+Convert.ToSring(a%100));