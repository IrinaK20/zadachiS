/*Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да*/ 


int[] arr = new int[5];

void newArray(int[] array)
{
    for (int i = 0; i < arr.Length; i++)
    {
        array[i] = new Random().Next(-9,10);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if (i < (arr.Length - 1)) Console.Write($",");
    }
    Console.WriteLine();
}

newArray(arr);
PrintArray(arr);

Console.WriteLine("введите число");

int number = Convert.ToInt32(Console.ReadLine());

string result=Poisk(arr,number)? $"число {number} входит в маcсив" : $"число {number} не входит в маcсив";
Console.WriteLine(result);

bool Poisk(int[] array,int n)
{
    bool h =false;
    for( int i=0; i< array.Length; i++)
    {
        if(array[i]==n)
        {
            h=true;
            break;
        }
    }
    return h;
}