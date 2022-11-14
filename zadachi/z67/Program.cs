// программа принимает на вход число и возвращает сумму его цифр 

Console.WriteLine("введите число ");
int a = Convert.ToInt32(Console.ReadLine());
int sum= Summa(a);
int Summa(int b)
{
    if (b/10>0) return Summa(b/10)+b%10;
    return b;
}
Console.WriteLine(sum);
