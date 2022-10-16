/*принимает на вход координаты точки (X и Y), причем X и Y не равны 0 
и выдаёт номер четверти поскости, в которой находится эта точка.*/


Console.Write("введите x:");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("введите y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.Write("1 четверть");
}
if (x < 0 && y > 0)
{
    Console.Write("2 четверть");
}
if (x < 0 && y < 0)
{
    Console.Write("3 четверть");
}
if (x > 0 && y < 0)
{
    Console.Write("4 четверть");
}

