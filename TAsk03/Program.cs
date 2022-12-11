// Задача 2: Задайте массив. 
// Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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
        Console.WriteLine($"{array[i]}\t");
    }
}
int Prompt(string message)
{
    Console.WriteLine($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}

int number = Prompt("Enter a number");
int Length = 5;
int minVal = 0;
int maxVal = 5;

int[] array = GenerateArray(Length, minVal, maxVal);

void Check(int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(number == array[i]) Console.WriteLine($"{array[i]} Yes"); 
        
           
    
        else Console.WriteLine($"{array[i]} No");
       

    }
}
Check(array);
