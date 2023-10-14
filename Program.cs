Напишите программу, которая подсчитывает количество четных элементов в массиве целых положительных трехзначных чисел и выводит результат на экран.

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
int count = 0;
FillArrayRandomNumbers(numbers);
PrintArray(numbers);


for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    count++;
}


Console.WriteLine($"количество чётных чисел в массиве -> {count} ");

void FillArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Напишите программу, которая находит сумму элементов с нечетными индексами в одномерном массиве целых чисел и выводит результат на экран.


int size = 4;
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

int sumNumbersEvenIndex = 0;

for (int i = 1; i < numbers.Length; i += 2)
{
    sumNumbersEvenIndex += numbers[i];
}
Console.Write(sumNumbersEvenIndex);



void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


Напишите программу для работы с массивом вещественных чисел.


int size = 10;
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

int max = numbers[0];
int min = numbers[0];

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
    else if (numbers[i] < min)
    {
        min = numbers[i];
    }
}

Console.WriteLine($"Минимальное число: {min}");
Console.WriteLine($"Минимальное число: {max}");
Console.WriteLine($"Разница между максимальным и минимальным числами: {max-min}");



void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 555);
    }
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}