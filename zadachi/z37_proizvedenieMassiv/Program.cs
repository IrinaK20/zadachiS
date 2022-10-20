/* Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследнийи т.д.
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 12 10 */

/*

int len = new Random().Next(5, 10);  // задаем рандомность
Console.WriteLine(len);              //выводим 

int[] arr = new Int32[len];

double half = Math.Ceiling((Convert.ToDouble(len) / 2));      // округление 
Console.WriteLine(half);

int[] arr2 = new Int32[Convert.ToInt32(half)];

fillMass(arr, 1, len);
PrintArray(arr);
numFind(arr, arr2);                    // то что выйдет на консоль - резуkьтат 
PrintArray(arr2);

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
int[] numFind(int[] array, int[] array2)
{
    for (int i = 0; i < (arr.Length) / 2; i++)
    {
        array2[i] = array[i] * array[array.Length - i - 1];
    }
    if (array.Length % 2 != 0)
    {
        array2[array.Length / 2 ] = array[array.Length / 2 ];
    }
    return array2;
} 
*/

Console.WriteLine("Введите колличество элементов массива:");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
//int[] arrayResult = new int[array.Length / 2 + array.Length % 2];
int[] arrayResult = new int[(array.Length + 1) / 2];
Random rand = new Random();
int number = array.Length;

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(1, 10);
}
Console.WriteLine(string.Join(", ", array));

for (int i = 0; i < arrayResult.Length; i++)
{
    arrayResult[i] = array[i] * array[array.Length - 1 - i];
}
if (array.Length % 2 != 0)
{
    arrayResult[arrayResult.Length - 1] = array[array.Length / 2];
}
Console.WriteLine("Произведение пар чисел:");
Console.WriteLine(string.Join(", ", arrayResult));