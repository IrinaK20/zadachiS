/* программа, на входринимает число (А), а на выходе показывает все 
цеые числа в промежутке от -А до А */

Console.WriteLine ("введите число:");
int n = Convert.ToInt32(Console.ReadLine()); 
int i=n*(-1);
while(i<=n)
{
    Console.Write (Convert.ToString(i) + " " );
    i++;
}
