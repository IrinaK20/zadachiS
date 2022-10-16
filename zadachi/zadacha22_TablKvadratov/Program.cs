/*принимает число N и выдает таблицу квадратов чисел от 1 до N
5->1,4,9,16,25 */

Console.WriteLine("введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int index=0;

for (int i=1; i<=n; i++)
{
    index=(int) i*i;
    Console.Write(index + " ");
}
