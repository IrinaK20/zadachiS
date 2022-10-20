/* программа выводит массив из 8 элементов, заполненный  0 и 1 в случайном порядке
[1,0,0,0,1,1,0,1]  */

int[] arr = new int[8];
void newArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        // Console.Write($"{array[i]} "); //вывод будет через пробел 
        Console.Write($"{array[i]}");
        if (i < (array.Length - 1)) Console.Write($","); // через запятую 
    }
    Console.WriteLine();
}
newArray(arr);
PrintArray(arr);