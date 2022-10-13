int Prompt(string message)
{
    System.Console.Write(message);           // Р’С‹РІРµСЃС‚Рё СЃРѕРѕР±С‰РµРЅРёРµ
    string readValue = Console.ReadLine();   // РЎС‡РёС‚С‹РІР°РµС‚ СЃ РєРѕРЅСЃРѕР»Рё СЃС‚СЂРѕРєСѓ
    int result = int.Parse(readValue);       // РџСЂРµРѕР±СЂР°Р·СѓРµС‚ СЃС‚СЂРѕРєСѓ РІ С†РµР»РѕРµ С‡РёСЃР»Рѕ
    return result;                           // Р’РѕР·РІСЂР°С‰Р°РµС‚ СЂРµР·СѓР»СЊС‚Р°С‚ С„СѓРЅРєС†РёРё
}
 
int Ax = Prompt("Р’РІРµРґРёС‚Рµ РєРѕРѕСЂРґРёРЅС‚Сѓ С‚РѕС‡РєРё A РїРѕ РѕСЃРё С… > ");
int Ay = Prompt("Р’РІРµРґРёС‚Рµ РєРѕРѕСЂРґРёРЅС‚Сѓ С‚РѕС‡РєРё A РїРѕ РѕСЃРё y > ");
int Az = Prompt("Р’РІРµРґРёС‚Рµ РєРѕРѕСЂРґРёРЅС‚Сѓ С‚РѕС‡РєРё A РїРѕ РѕСЃРё z > ");
int Bx = Prompt("Р’РІРµРґРёС‚Рµ РєРѕРѕСЂРґРёРЅС‚Сѓ С‚РѕС‡РєРё B РїРѕ РѕСЃРё С… > ");
int By = Prompt("Р’РІРµРґРёС‚Рµ РєРѕРѕСЂРґРёРЅС‚Сѓ С‚РѕС‡РєРё B РїРѕ РѕСЃРё y > ");
int Bz = Prompt("Р’РІРµРґРёС‚Рµ РєРѕРѕСЂРґРёРЅС‚Сѓ С‚РѕС‡РєРё B РїРѕ РѕСЃРё z > ");
 
double Length(int x, int y, int z)
{
    double result = Math.Sqrt((Ax - Bx) * (Ax - Bx) + (Ay - By) * (Ay - By) + (Az - Bz) * (Az - Bz));
    System.Console.WriteLine(result);
    return result;
}
Length(Ax, Ay, Az);
