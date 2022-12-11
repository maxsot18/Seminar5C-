// Задача 3: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным 
// элементом массива.

// [3 7 22 2 78] -> 76

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
int Length = 6;
int minrange = 0;
int maxrange = 100;


int[] array = GenerateArray(Length, minrange, maxrange);

Console.Write($"Array is   ");
PrintArray(array);
int MaxValue(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }
    return max;

  
}

int max = MaxValue(array);

int MinValue ( int[] array)
{
      int min = array[0];
      for (int j = 0; j < array.Length; j++)
    {
        if (min > array[j])
        {
            min = array[j];
        }
    }
    return min;

}
int min = MinValue(array);
int sub = max - min;
Console.WriteLine($"Max value is {max}, min value is {min}");
Console.WriteLine($"Substraction between max and min values = {sub}");
