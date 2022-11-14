//программа которая выведет все натуральные числа в промежутке от N до M 

Console.WriteLine("введите число N");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число M");
int M = Convert.ToInt32(Console.ReadLine());
string NumbersRec(int N, int M)
{
    if (N <= M) return $"{N} " +  NumbersRec (N + 1, M);
    else return String.Empty;
}

Console.WriteLine(NumbersRec(N,M));

