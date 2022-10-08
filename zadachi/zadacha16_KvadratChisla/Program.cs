// ввести два числа и проверить,явл ли одно число квадратом другого
// 5,25->да 
// 25,5->да 
// 8,9->нет


Console.Write("введите чисо a:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("введите чисо b: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a*a==b || b*b==a)
{
    Console.WriteLine("одно число явл квадратом другого");
}
else
{
     Console.WriteLine("ни одо число не явл квадратом другого");
}
