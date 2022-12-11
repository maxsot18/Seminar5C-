// Задача 1: Напишите программу замены элементов массива: 
// положительные элементы замените 
// на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 
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

void ChangeNummbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int number = array[i];
        if (number < 0)
        {
            number = number * (-1);
            Console.Write($"{number}\t");
        }
        else
        {
            Console.Write($"{array[i]}\t");
        }

    }
}

int length = 5;
int minRange = -100;
int maxRange = 800;
Console.WriteLine("Generated array ");
int[] arr = GenerateArray(length, minRange, maxRange);
PrintArray(arr);
Console.WriteLine("Made array ");
ChangeNummbers(arr);