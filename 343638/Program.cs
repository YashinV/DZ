// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


//  int Prompt(string message)
// {
//     System.Console.Write(message); 
//     string readValue = Console.ReadLine(); 
//     int result = int.Parse(readValue); 
//     return result; 
// }

int[] CreatArray(int length)
{
    // double [] answer1 = new  double[length];//
    int[] answer = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.Next(100, 999);
    }
    return answer;
}
 
int CountElements(int[] a)
{
   
    int Count = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i]%2 == 0)
        {
           
            Count++;
        }
    }
    return Count;
}
 
void printArray(int[] answer)
{
    int count = 0;
    while (count < answer.Length)
    {
        System.Console.Write($"{answer[count]}\t");
        count++;
    }
    System.Console.WriteLine();
}
 
int[] array1 = CreatArray(5);
printArray(array1);
System.Console.WriteLine(CountElements(array1));
System.Console.WriteLine();
System.Console.WriteLine(SumElements1(array1));

// System.Console.WriteLine(MaxMinDifferenceElements(array));


// System.Console.WriteLine(MaxMinDifferenceElements(array2));
// Задача 36: Задайте одномерный массив, заполненныйarray1 случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
int SumElements1(int[] a)
{
    int Sum = 0;
    for (int i = 1; i < a.Length; i = i + 2)
    {
        Sum = Sum + a[i];
    }
    return Sum;
}
 

void printArray1(int[] answer)
{
    int count = 0;
    while (count < answer.Length)
    {
        System.Console.Write($"{answer[count]}\t");
        count++;
    }
    System.Console.WriteLine();
}
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// double MaxMinDifferenceElements(double[] a)
// {
//     double max = a[0];
//     double min = a[0];
//     for (int i = 1; i < a.Length; i++)
//     {
//         if (a[i] > max)
//         {
//             max = a[i];
//         }
//          if (a[i] < min)
//         {
//             min = a[i];
//         }
//     }
//     return max-min;
// }
 

// void printArray2(double[] answer)
// {
//     int count = 0;
//     while (count < answer.Length)
//     {
//         System.Console.Write($"{answer[count]}\t");
//         count++;
//     }
//     System.Console.WriteLine();
// }
 

