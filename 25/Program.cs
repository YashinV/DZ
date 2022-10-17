// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
 

Console.Write("Введите первое целое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число ");
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Math.Pow(a,b));
// Console.WriteLine("a^b = " + Math.Pow(a^b ));

Console.Write(c);






// не понял
// int Prompt(string message)
// {
//     System.Console.Write(message); //Р’С‹РІРѕРґРёРј РїСЂРёРіР»Р°С€РµРЅРёРµ РєРѕ РІРІРѕРґСѓ
//     string readInput = System.Console.ReadLine(); // Р’РІРѕРґРёРј Р·РЅР°С‡РµРЅРёРµ
//     int result = int.Parse(readInput); //РїСЂРёРІРѕРґРёРј Рє С‡РёСЃР»Сѓ
//     return result; //РІРѕР·РІСЂР°С‰Р°РµРј СЂРµР·СѓР»СЊС‚Р°С‚
// }
 
// int Power(int powerBase, int exponent)
// {
//     int power = 1;
//     for (int i = 0; i < exponent; i++)
//     {
//         power *= powerBase;
//     }
//     return power;
// }
 
// bool ValidateExponent(int exponent)
// {
//     if (exponent < 0)
//     {
//         System.Console.WriteLine("РџРѕРєР°Р·Р°С‚РµР»СЊ РЅРµ РґРѕР»Р¶РµРЅ Р±С‹С‚СЊ РјРµРЅСЊС€Рµ РЅСѓР»СЏ");
//         return false;
//     }
//     return true;
// }
 
// int powerBase = Prompt("Р’РІРµРґРёС‚Рµ РѕСЃРЅРѕРІР°РЅРёРµ: ");
// int exponent = Prompt("Р’РІРµРґРёС‚Рµ РїРѕРєР°Р·Р°С‚РµР»СЊ: ");
// if (ValidateExponent(exponent))
// {
//     System.Console.WriteLine($"Р§РёСЃР»Рѕ {powerBase} РІ СЃС‚РµРїРµРЅРё {exponent} СЂР°РІРЅРѕ {Power(powerBase, exponent)}");
// }