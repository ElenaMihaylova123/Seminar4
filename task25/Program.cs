﻿// Задача 25.
//Программа, которая принимает на вход числа А и Б, а потом возводит число А в степень Б


//число, которое нужно возвести в степень
Console.Write("Введите число   : ");
int num = int.Parse(Console.ReadLine());
//степень числа
Console.Write("Введите степень : ");
int n = int.Parse(Console.ReadLine());
//число, возведенное в степень
int num_n=1;
for(int i=0; i<n; i++) {
    num_n*=num;
}
Console.WriteLine("{0} ^ {1} = {2}", num, n, num_n);
Console.ReadKey();
