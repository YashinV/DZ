int Prompt(string message)
{
    System.Console.Write(message); // Р’С‹РІРµСЃС‚Рё СЃРѕРѕР±С‰РµРЅРёРµ
    string readValue = Console.ReadLine(); // РЎС‡РёС‚С‹РІР°РµС‚ СЃ РєРѕРЅСЃРѕР»Рё СЃС‚СЂРѕРєСѓ
    int result = int.Parse(readValue); // РџСЂРµРѕР±СЂР°Р·СѓРµС‚ СЃС‚СЂРѕРєСѓ РІ С†РµР»РѕРµ С‡РёСЃР»Рѕ
    return result; // Р’РѕР·РІСЂР°С‰Р°РµС‚ СЂРµР·СѓР»СЊС‚Р°С‚ С„СѓРЅРєС†РёРё
}
 
int N = Prompt("Р’РІРµРґРёС‚Рµ N > ");
int num = 1;
void CubeN(int num)
{
    while (num <= N)
    {
        int result = 0;
        result = num * num * num;
        System.Console.WriteLine(result);
        num++;
    }
}
CubeN(num);
