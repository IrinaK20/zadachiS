﻿/* Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8*/


        int numberFirst = 0;
        int nuberSecond = 1;

        int count =5;

        for (int i = 0; i < count; i++)
        {
            Console.Write(numberFirst +"\t");
            int temp = nuberSecond;
            nuberSecond = numberFirst + nuberSecond;
            numberFirst = temp;
        }
