int Prompt(string message)
{
    System.Console.Write(message); // Р’С‹РІРµСЃС‚Рё СЃРѕРѕР±С‰РµРЅРёРµ
    string readValue = Console.ReadLine(); // РЎС‡РёС‚С‹РІР°РµС‚ СЃ РєРѕРЅСЃРѕР»Рё СЃС‚СЂРѕРєСѓ
    int result = int.Parse(readValue); // РџСЂРµРѕР±СЂР°Р·СѓРµС‚ СЃС‚СЂРѕРєСѓ РІ С†РµР»РѕРµ С‡РёСЃР»Рѕ
    return result; // Р’РѕР·РІСЂР°С‰Р°РµС‚ СЂРµР·СѓР»СЊС‚Р°С‚ С„СѓРЅРєС†РёРё
}
 
int N = Prompt(" введите число больше 10000 ");
void Palindrome(int N)
{
    if (N > 10000 && N < 100000)
    {
        int number1 = N / 10000;
        int number5 = N % 10;
        if (number1 == number5)
        {
            int number2 = N / 1000 % 10;
            int number4 = N / 10 % 10;
            if (number2 == number4)
            {
                System.Console.WriteLine("палиндром");
            }
            else
                System.Console.WriteLine("?????? ");
        }
        else
            System.Console.WriteLine("не пилиндром");
    }
    else
    {
        System.Console.WriteLine("вы ввели число не пятизначное");
 
    }
}
 
Palindrome(N);




