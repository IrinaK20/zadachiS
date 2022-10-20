/*Напишите программу замены элементов массива: положительные элементы замените на
соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]*/


int[] array = new int[4];

randomFilling(array, min: -9, max: 10);
arrayOutput(array);
singChange(array);
arrayOutput(array);

void singChange(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i]=arr[i]*-1;
    }
    
}
void randomFilling(int[] arr, int min, int max)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
}
void arrayOutput(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if (i < (arr.Length - 1)) Console.Write($",");
    }
    Console.WriteLine();
}
