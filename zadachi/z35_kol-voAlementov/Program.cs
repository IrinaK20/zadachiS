/* Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5*/


int[] arr = new int[10];    // задаем длинну массива

fillMass(arr, -10, 120);
PrintArray(arr);
numFind(arr);

int[] fillMass(int[] array, int from, int to)
{
    for (int i = 0; i < arr.Length; i++)
    {
        array[i] = new Random().Next(from, to + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
void numFind(int[] array)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
        {
            sum++;
        }
    }
    Console.WriteLine($"{sum}");
}
