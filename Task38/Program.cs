/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

double[] GetArray(int demension)
{
    double[] array = new double[demension];
    Random randomise = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randomise.Next(0, 1000);
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
(double, double) GetMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return (max, min);
}

Console.WriteLine("Введите размер массива:");
int demension = int.Parse(Console.ReadLine());

double[] randomArray = GetArray(demension);
PrintArray(randomArray);
(double max, double min) = GetMaxMin(randomArray);
double diff = max - min;
Console.WriteLine($"Разница между минимальным и максимальным элементом массива составляет {diff}");
