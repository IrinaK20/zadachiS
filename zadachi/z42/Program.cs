/* Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10 */ 

int number =120;   // тут менять число которое проверяем 
int result=0;
int bias=1;     // сдвиг 

while(number>0)
{
    result+=number%2*bias;
    bias*=10;
    number/=2;
}
Console.WriteLine(result);


