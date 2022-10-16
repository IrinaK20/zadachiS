/*программа принимает на вход число n и выдает сумму чисел от 1 до n
7->28
4->10
8->36 */

Console.WriteLine("введите число: ");

int n = int.Parse(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());

int sum = 0;
for (int i = 1; i <= n; i++)
{
    sum += i;
    //sum=sum+i;
}
Console.WriteLine($"сумма от 1 до {n}: {sum}");