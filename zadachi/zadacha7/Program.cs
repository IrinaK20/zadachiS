/*принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа*/

Console.WriteLine("введите трехзначное число: ");
int n=Convert.ToInt32(Console.ReadLine());
while(n<100|n>999)
{
    Console.Write("недопустимое число, повторите ввод: ");
    n=Convert.ToInt32(Console.ReadLine());
}
Console.Write("поседняя цифра числа:" + Convert.ToString(n%10));