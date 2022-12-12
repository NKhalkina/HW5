/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

//инициализирует новый массив
int[] InitArray(int length) 
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(99,1000);
    }
    return array;
}

//печатает массив на экран
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//получает количество положительных чисел
int Count(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] %2 == 0) count++;
    }
    return count;
}

Console.WriteLine("Введите размер массива");
int [] array = InitArray(int.Parse(Console.ReadLine()));
PrintArray(array);

Console.WriteLine($"количество четных чисел в массиве: {Count(array)}");
