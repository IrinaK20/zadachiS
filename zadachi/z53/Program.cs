
/*Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.*/

int rows = 4;
int columns = 4;
Random random = new Random();
int[,] array = new int[rows, columns];

Console.WriteLine();
FillArray(array);
PrintArray(array);
Console.WriteLine();
SwopLines(array);
PrintArray(array);

void FillArray(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(1, 11);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void SwopLines(int[,] array)
{
    for (int j = 0; j < columns; j++)
    {
        int temp = array[0, j];
        array[0, j] = array[rows - 1, j];
        array[rows - 1, j] = temp;
    }
}