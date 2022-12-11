// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
int[] GenerateArray(int Length, int MinValue, int MaxValue)
{
    int[] numbers = new int[Length];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(MinValue, MaxValue + 1);
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
// int Prompt(string message)
// {
//     Console.WriteLine($"{message}");
//     return Convert.ToInt32(Console.ReadLine());
// }

int length = 10;
int minValue = -100;
int MaxValue = 100;

int[] array = GenerateArray(length, minValue, MaxValue);
Console.WriteLine("Array is ");
PrintArray(array);
int sum = 0;
for (int i = 0; i < array.Length; i++)
{

    if (i % 2 != 0)
    {
        sum += array[i];
    }

}
Console.Write($"Sum of negative index = {sum}");