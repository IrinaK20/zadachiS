// принимает два числа и выводит в целую степень

Console.WriteLine("введите число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число ");
int n = Convert.ToInt32(Console.ReadLine());

int PowerRec(int a,int n)
{
    return n == 0 ? 1 : PowerRec(a, n - 1) * a;
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
}
Console.WriteLine(PowerRec(a,n));