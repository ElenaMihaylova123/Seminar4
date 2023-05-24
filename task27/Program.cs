// Задача 26.
//Сумма цифр числа

//Ввод числа
Console.Write("Введите число   : ");
int a = int.Parse(Console.ReadLine());

int s = 0;
while (a > 0)
{
    s = s + a % 10;
    a = a /10 ;
}
Console.WriteLine(s);
Console.ReadKey();