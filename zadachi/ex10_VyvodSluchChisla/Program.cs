// вывод случ трёхзначного числа и удаяет вторую цифру этого числа 456->46 

int n = new Random().Next(100, 999);

Console.WriteLine(n);

int first =n/100;
int third =n%10;

Console.WriteLine(first);
Console.WriteLine(third);
Console.WriteLine(first+""+third);

