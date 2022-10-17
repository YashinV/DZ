// Задача 29: Напишите программу, которая задаёт массив произвольной длины,
// заполняет произвольными элементами и выводит их на экран.
// Длину массива и элементы массива можно задать рандомно или попросить пользователя ввести в консоли.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


// int[] arr = new int[3];
// for(int i=0;i<arr.Length;i++)
// {
//    Console.WriteLine(string.Format("Введите {0}й элемент массива:",i+1));
//    arr[i] = Convert.ToInt32(Console.ReadLine());//Если пользователь введет абракадабру, то вылетит исключение,
// //без преобразования нельзя, вы всегда получаете введенную пользователем информацию в типе string.
// }
// Random random= new Random();
// for(int i =0;i<arr.Length;i++)
//    arr[i] = random.Next(-100,100);//Заполняем случайными числами диапозоном от -100 до 100



// int data = arr[0]+10;// В data будет записано значение первого элемента массива увеличенное на 10


int Prompt(string message)
{
    System.Console.Write(message); 
    string ReadInput = System.Console.ReadLine();
    int result = int.Parse(ReadInput); 
    return result; 
}

int[] GenerateArray(int Length, int minValue, int maxValue)
{
    int[] array = new int[Length]; 
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1); 
    }
    return array;
}
 
void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, "); 
    }
    System.Console.Write($"{array[array.Length - 1]}"); 
    System.Console.WriteLine("]");
}
int length = Prompt("Р”Р»РёРЅР° РјР°СЃСЃРёРІР°: ");
int min = Prompt("РќР°С‡Р°Р»СЊРЅРѕРµ Р·РЅР°С‡РµРЅРёРµ, РґР»СЏ РґРёР°РїР°Р·РѕРЅР° СЃР»СѓС‡Р°Р№РЅРѕРіРѕ С‡РёСЃР»Р°: ");
int max = Prompt("РљРѕРЅРµС‡РЅРѕРµ Р·РЅР°С‡РµРЅРёРµ, РґР»СЏ РґРёР°РїР°Р·РѕРЅР° СЃР»СѓС‡Р°Р№РЅРѕРіРѕ С‡РёСЃР»Р°:");
int[] array = GenerateArray(length, min, max); 
PrintArray(array); 
