/* Напишите программу, которая принимает на вход три числа и проверяет,
может ли существовать треугольник со сторонами такой длины.
(Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон.) */



Console.WriteLine("введите три числа");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int C = Convert.ToInt32(Console.ReadLine());
Triangle(A, B, C);

void Triangle(int a, int b, int c)
{
if (a + b > c && b + c > a && c + a > b)
{
    Console.WriteLine("треугольник существует");
}
else  Console.WriteLine("треугольник не существует");
}

