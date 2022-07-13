/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int[] GetArray(int demension)
{
    int[] array = new int[demension];
    Random randomiser = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randomiser.Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void CountEvenNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Количество четных числе в массиве: {count}");
}

Console.WriteLine("Введите размер массива:");
int demension = int.Parse(Console.ReadLine());
int[] randomArray = GetArray(demension);
PrintArray(randomArray);
CountEvenNumber(randomArray);
