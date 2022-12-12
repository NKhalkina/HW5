/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

//инициализирует новый массив
int[] InitArray(int length)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(-10,10);
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

//находим сумму элементов, стоящих на нечётных позициях

int GetPositiveSumm(int[] array)
{
    int summ = 0;
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (count%2 == 1)
            summ = summ + array[i];
            count = i + 1;

    }
    return summ;
}

int[] arr = InitArray(6);
PrintArray(arr);
int positiveSumm = GetPositiveSumm(arr);
Console.WriteLine($"сумма элементов, стоящих на нечётных позициях, равна {positiveSumm}");



