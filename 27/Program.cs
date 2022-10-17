// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12
 Console.Write("Введите число: ");
 // Console.WriteLine(" введите число ");
//int nun = Convert.ToInt32(Console.ReadLine()); 
string textNumber = Console.ReadLine();
int length = textNumber.Length;
int result = 0;
for (int i=0; i < length; i++)
{
   result = result + Convert.ToInt32(Convert.ToString(textNumber[i]));
}




// for (int i = 0; i< length; i++)
// {
//     result = result + textNumber [i];

System.Console.WriteLine(result);



//        int Prompt(string message)
// {
//     System.Console.Write(message); //Р’С‹РІРѕРґРёРј РїСЂРёРіР»Р°С€РµРЅРёРµ РєРѕ РІРІРѕРґСѓ
//     string readInput = System.Console.ReadLine();
//     int result = int.Parse(readInput); //РїСЂРёРІРѕРґРёРј Рє С‡РёСЃР»Сѓ
//     return result; //РІРѕР·РІСЂР°С‰Р°РµРј СЂРµР·СѓР»СЊС‚Р°С‚
// }
 
// int SumAllDigit(int number)
// {
//     int result = 0;
//     while (number > 0)
//     {
//         result += number % 10;
//         number = number / 10;
//     }
//     return result;
// }
 
// int number = Prompt("Р’РІРµРґРёС‚Рµ С‡РёСЃР»Рѕ:");
// System.Console.WriteLine($"РЎСѓРјРјР° РІСЃРµС… С‡РёСЃРµР» РІ С†РёС„СЂРµ {number} = {SumAllDigit(number)}")