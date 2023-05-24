// Задача 29.
//Задание числами массива из 8 элементов и вывод массива


int size = 8;
int[] array = new int[8];
Random myRandom = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = myRandom.Next(0, 20);
    Console.Write("{0} ", array[i]);
}
Console.WriteLine("");
Console.ReadKey();