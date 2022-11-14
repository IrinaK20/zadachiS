/*задать начение N, программа которая выводит от 1 до N*/ 

Console.WriteLine("введите число");

int b = Convert.ToInt32(Console.ReadLine());
int a = 1;
string NumbersRec(int a, int b)
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
    else return String.Empty;
}

Console.WriteLine(NumbersRec(a,b));
