/*Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали 
(с индексами (0,0); (1;1) и т.д.
*/

int rows = 4;
int columns = 4;
Random random = new Random();
int[,] array = new int[rows, columns];
FillArray(array);
PrintArray(array);
SummArray(array);


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

void SummArray(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (i == j)
            {
                sum += array[i, j];
                Console.Write(array[i, j] + " + ");
            }
        }
    }
    Console.Write("\b\b");
    Console.WriteLine($"сумма равна: {sum}");
}

