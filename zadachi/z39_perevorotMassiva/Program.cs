/*Напишите программу, которая перевернётодномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6] */

int[] array=new int [8];
//int[] secondArray = new int [array.Length];
FillArray(array, 1,10);
PrintArray (array);
Console.WriteLine();
int MaxIndex=array.Length-1;

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


for (int i =0; i< array.Length/2; i++)
{
    //secondArray[MaxIndex-i]=array[i];            // первый способ 

    //int temp=array[i];
    //array[i]= array[MaxIndex-i];            //второй способ 
    //array[MaxIndex-i]=temp;

    (array[i],array[MaxIndex-i]) =(array[MaxIndex-i],array[i]);     // третий 
}
PrintArray (array);