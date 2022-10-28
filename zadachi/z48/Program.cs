/*Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: A = m+n.
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5*/     //тут складываются индекса именно 


int rows = 3;
int columns = 4;

int[,] array = new int[rows, columns]; 

FillArray(array, rows,columns);
PrintArray(array, rows,columns);

void FillArray(int[,] array,int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = i+j ;
        }
    }
}

void PrintArray(int[,] array, int rows, int columns)
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
