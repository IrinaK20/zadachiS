/*принимат на вход две координаты 2-х точек и находит расстояние мжду ними в 2D пространстве
A(3,6); B(2,1)->5,09 */

Console.WriteLine("A1(x1;y2),A2(x2,y2)");
Console.Write("input x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input x2: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input Y1: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("input Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("A1A2 lenght is: " + Math.Round(Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2)), 2));

// Math.Round(),2));  используется для округления 
//Math.Sqrt это квадратный корень
