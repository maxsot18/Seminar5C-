// Задача 1: Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

int[] GenerateArray(int Length, int MinValue, int MaxValue)
{
    int[] numbers = new int[Length];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(MinValue, MaxValue);
    }
    return numbers;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t");
    }
}

int Sumnegative(int[] array)
{
    int sum = 0;
    // for(int i = 0; i < array.Length; i++)
    // {
    //     int item = array[i];
    //     // тело цикла
    // }

    foreach (int item in array)
    {
        if (item < 0)
        {
            sum += item;
        }

        // тело цикла
    }
    return sum;
}

int Sumpositive(int[] array)
{
    int sum = 0;
    

    foreach (int item in array)
    {
        if (item >= 0)
        {
            sum += item;
        }

        // тело цикла
    }
    return sum;
}

int length = 12;
int min = -9;
int max = 10;
int[] arr = GenerateArray(length, min, max);
PrintArray(arr);
int Sumplus = Sumpositive(arr);
int Summinus = Sumnegative(arr);
Console.WriteLine($"Sum of positive numbers = {Sumplus}, sum of negative numbers {Summinus}");