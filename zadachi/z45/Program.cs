/*Напишите программу, которая будет создавать копию заданного массива
 с помощью поэлементного копирования. */

 int[] array=new int [8];
int[] secondArray = new int [array.Length];
FillArray(array, 1,10);
PrintArray (array);
SeconArr(array, secondArray);
PrintArray(secondArray);

void FillArray(int[] array, int startNumber = 0, int finishNumber = 1)
{
    finishNumber++;
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(startNumber, finishNumber);
    }
}

void PrintArray(int[] array)
{
    Console.WriteLine("вывод массива");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
    Console.WriteLine();
}

int [] SeconArr( int[] arr, int [] arr2)
{
    for(int i=0;i<arr.Length; i++)
    {
        arr2[i]=arr[i];
    }
    return arr2;
}