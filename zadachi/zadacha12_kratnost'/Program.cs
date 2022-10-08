// программа приимает на вход два числа и выводит, явл ли первое число кратным второму.
// если число 1 не кратно числу 2,то прграмма выводит остаток от деления.
// 34,5-> не кратно, остаток 4
// 16,4-> кратно

Console.WriteLine ("введите первое число");
int a = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine ("введите второе число");
int b = Convert.ToInt32(Console.ReadLine()); 
 
 if(a%b==0)
 {
    Console.WriteLine ("кратно");
 }
 else
 {
    Console.WriteLine ("не кратно, остаток: " + a%b);
 }