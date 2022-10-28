/*Задайте двумерный массив размером m × n, заполненный случайными целыми числами.
m = 3, n = 4.
1   4   8   19
5   -2  33  -2
77  3   8   1 */


Random random = new Random();
int rows = 4;
int columns = 5;

int[,] array = new int[rows, columns]; // 4*5

//Console.WriteLine(array.GetLength(0));  // строки 
//Console.WriteLine(array.GetLength(1));  //  столбцы
FillArray(array);
PrintArray(array);

void FillArray(int[,] array)
{
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

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
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
