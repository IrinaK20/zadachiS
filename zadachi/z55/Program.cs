/*Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя.*/ 

int rows = 3;
int columns = 3;
Random random = new Random();
int[,] array = new int[rows, columns];

FillArray(array);
PrintArray(array);
Console.WriteLine();
Replacement(array);
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

void Replacement(int[,] array)
{
    for (int i = 0; i < rows-1; i++)
    {
        for (int j = i; j < columns; j++)
        {
          int temp = array[j,i];
          array[j,i]=array[i,j];
          array[i,j]=temp;
        }
    }
}