/*принимает число n и выдает произведение чисел от 1 до n
4->24
5->120 */ 

Console.WriteLine("введите число: ");

int n = int.Parse(Console.ReadLine());
int mul = 1;
for (int i = 1; i <= n; i++)
{
    mul *= i;
    //mul=mul*i;
}
Console.WriteLine($"произведение от 1 до {n}: {mul}"); 



