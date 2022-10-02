/*программа, которая на вход принимает два числа и проверяет,
 является ли первое число квадратом второго*/

Console.WriteLine ("введите первое число");
int a = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine ("введите второе число");
int b = Convert.ToInt32(Console.ReadLine()); 

if(a==b*b)
{
  Console.WriteLine ("yes");  
}
else
{
    Console.WriteLine ("no");
}
