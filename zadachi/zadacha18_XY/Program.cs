/*по заданному номеру четверти,показывает диапазон возможных
 координат точек в этой четверти X и Y*/

/*
Console.Write("введите № четверти: ");
string quarter = Console.ReadLine();

if (quarter =="1")
{
    Console.Write("x > 0 && y > 0");
}
else if (quarter == "2")
{
    Console.Write("x < 0 && y > 0");
}
else if (quarter == "3")
{
    Console.Write("x < 0 && y < 0");
}
else if (quarter == "4")
{
    Console.Write("x > 0 && y < 0");
}
else
{
  Console.Write("ввели некорректное значение, введите от 1 до 4 ");
}
*/

Console.Write("введите № четверти: ");
int q = Convert.ToInt32(Console.ReadLine());

switch (q)
{
    case 1:
        {
            Console.Write("x > 0 && y > 0");
            break;
        }
    case 2:
        {
            Console.Write("x < 0 && y > 0");
            break;
        }
    case 3:
        {
            Console.Write("x < 0 && y < 0");
            break;
        }
    case 4:
        {
            Console.Write("x > 0 && y < 0");
            break;
        }
    default:
        Console.WriteLine("ввели некорректное значение, введите от 1 до 4 ");
        break;
}