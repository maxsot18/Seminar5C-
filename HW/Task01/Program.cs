// Задача 1: Задайте массив заполненный случайными 
// положительными трёхзначными числами. 
// Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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
int Prompt(string message)
{
    Console.WriteLine($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}

int length = Prompt("Enter a length of array");
int minValue = 100;
int MaxValue = 1000;

int[] array = GenerateArray(length, minValue, MaxValue);
Console.WriteLine("Array is ");
PrintArray(array);
int quant = 0;
for (int i = 0; i < array.Length; i++)
{
    // int quant = 0;
    if (array[i] % 2 == 0)
    {
        quant++;

        
    }
    
}
Console.Write($"Quantity of positive numbers = {quant}");