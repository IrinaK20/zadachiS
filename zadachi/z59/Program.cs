/*Задайтедвумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент массива.*/

int rows = 4;
int columns = 4;
Random random = new Random();
int[,] array = new int[rows, columns];
int[,] array2 = new int[rows-1, columns-1];
int coordinateI = 0;
int coordinateJ = 0;

Console.WriteLine();
FillArray(array);
PrintArray(array);
Deletion(array, array2);
Console.WriteLine();
Console.WriteLine(coordinateI);
Console.WriteLine(coordinateJ);
Console.WriteLine();
PrintArray(array2);

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
   for (int i = 0; i < array.GetLength(0); i++) 
   { 
    for (int j = 0; j < array.GetLength(1); j++) 
    { 
     Console.Write(array[i, j] + "\t"); 
    } 
    Console.WriteLine(); 
   } 
  }

void Deletion(int[,] array, int[,] array2)
{
    int min = array[0, 0];
    int flagI = 0;
    int flagJ = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                coordinateI = i;
                coordinateJ = j;

            }
        }

    }

   for (int i = 0; i < array.GetLength(0) - 1; i++)
    {
        for (int j = 0; j <array.GetLength(1) - 1; j++)
        {
            if (i < coordinateI) flagI = 0;
            else flagI = 1;

            if (j < coordinateJ) flagJ = 0;
            else flagJ = 1;

            array2[i, j] = array[i + flagI, j + flagJ];
        }
    }
}

