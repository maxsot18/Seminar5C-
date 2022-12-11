// Задача 3: Задайте одномерный массив из 10 
// случайных чисел в диапазоне от 1 до 200. 
// Найдите количество  двузначных элементов массива. 
// Пример для массива из 5, а не 10 элементов. 
// В своём решении сделайте для 10
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

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

int length = 10;
int minVal = 1;
int maxVal = 200;

int[] array = GenerateArray(length, minVal, maxVal);

void twodigit(int[] array)
{
    int quant = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        int number = array[i];
        if (number > 10 & number <100)
        {
           quant++;
           
           
        }
        
       
    }
    Console.Write($"{quant}");
}
Console.WriteLine("Array is ");

PrintArray(array);
Console.WriteLine("Quantity of two digit numbers");
twodigit(array);

