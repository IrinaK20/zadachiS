// принимает на вход число и проверяет,кратно ли оно одновременно 7 и 23

/*
Console.WriteLine ("введите число");
int n = Convert.ToInt32(Console.ReadLine());

if (n/7==23)
{
    Console.WriteLine("да,оно кратно");
}
else
{
     Console.WriteLine("нет,попробуйте ещё раз");

}   */

// ввариант 2

Console.WriteLine ("введите число");
int n = Convert.ToInt32(Console.ReadLine());

if (n%7==0 && n%23==0)
{
    Console.WriteLine("да,оно кратно 7 и 23");
}
else
{
     Console.WriteLine("число не кратно 7 и 23");
}
