/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

int[] GetArray(int demension)
{
    int[] array = new int[demension];
    Random randomiser = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randomiser.Next();
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

(double, double) SummEvenAndOddPosition(int[] array)
{
    double evenPositionSumm = 0;
    double oddPositionSumm = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)
        {
            evenPositionSumm += array[i];
        }
        else
        {
            oddPositionSumm += array[i];
        }
    }
    return (evenPositionSumm, oddPositionSumm);
}

Console.WriteLine("Введите размерность массива:");
int demension = int.Parse(Console.ReadLine());

int[] randomArray = GetArray(demension);
PrintArray(randomArray);
(double evenPositionSumm, double oddPositionSumm) = SummEvenAndOddPosition(randomArray);
Console.WriteLine($"Сумма элементов, стоящих на четных местах массива равна {evenPositionSumm}, сумма элементов, стоящих на нечетных местах массива равна {oddPositionSumm}");
