/*программа принимает на вход число и выдает кол-во цифр в числе
456->3
78->2
89126->5*/

/*
Console.WriteLine("введите число: ");

int n = int.Parse(Console.ReadLine());
int count = 0;
if (n == 0)
{
    count = 1;
}
else
{
    while (n > 0)
    {
        count += 1;
        n = n / 10;
    }
}
Console.WriteLine($"цифр в числе: {count}");

*/

Console.WriteLine("введите число: ");

int n = int.Parse(Console.ReadLine());
int count = 0;
if (n == 0)
{
    count = 1;
}
else while (n != 0)
{
        count += 1;
        n = n / 10;
}
Console.WriteLine($"цифр в числе: {count}"); 