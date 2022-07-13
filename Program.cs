// Задача 1. (34) Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


int[] array = new int[5]; // в скобках длина массива
int countChet = 0;
int countNeChet = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 999);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

for (int j = 0; j < array.Length; j++)
{
    if (array[j] % 2 == 0) countChet = countChet + 1;
    else countNeChet = countNeChet + 1;
}
Console.WriteLine("Четные числа массива: " + countChet);
Console.WriteLine();
Console.WriteLine("Нечетные числа массива: " + countNeChet);


//Задача 2.  (36): Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = new int[5];
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
    Console.Write(array[i] + " ");
}
for (int j = 0; j < array.Length; j++)
{
    if (j % 2 == 1) count = count + array[j];

}
Console.WriteLine();
Console.Write("Сумма элементов на нечетной позиции в массиве равна - " + count);

//Задача 3 (38): Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] array = { 0, 3, 4, 5, 6, 7, 8, 9, 10, 20 };
int max = array[0];
int min = array[0];

for (int j = 0; j < array.Length; j++)
{
    if (array[j] > max) 
    max = array[j];
    if (array[j] < min) 
    min = array[j];
}
Console.WriteLine();
Console.Write("Разница между максимальным и минимальным элементом равна - ");
Console.Write(max - min);