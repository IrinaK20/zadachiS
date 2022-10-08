//программа, которая выводит число из отрезка [10, 99]
// и показывает наибоьшую цифру числа

int n = new Random().Next(10, 99);

Console.WriteLine(n);

int first =n/10;
int second =n%10;

Console.WriteLine(first);
Console.WriteLine(second);

if (first>second)
{
    Console.WriteLine(first);
}
else
{
    Console.WriteLine(second);
}