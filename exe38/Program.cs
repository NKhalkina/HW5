/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

//Задаем массив вещеcтвенных чисел
double[] GetArray(int length)
{
    double[] arr = new double[length];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = 5 - rnd.Next(11) + rnd.NextDouble();
    }
    return arr;
}


//Выводим на печать
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

// Находим мах и min
(double, double) GetMinAndMax(double[] array)
{
    double max = 0;
    double min = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
        else if (array[i] > max)
            max = array[i];
    }
    return (min, max);
}



Console.WriteLine("Введите размер массива");
double [] array = GetArray(int.Parse(Console.ReadLine()));
PrintArray(array);
(double min, double max) = GetMinAndMax(array);

Console.WriteLine($"Min: {min}, Max: {max}");

Console.WriteLine(max-min);