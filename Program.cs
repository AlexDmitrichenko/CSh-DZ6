﻿//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
//строго больше 0 ввёл пользователь. 0, 7, 8, -2, -2 -> 2,  0, 1, -7, 567, 89, 223-> 4
/*Console.Write("Введите M чисел через пробел: ");
string M = Console.ReadLine()!;
string[] num = M.Split(' ', StringSplitOptions.RemoveEmptyEntries);
int count = 0;
foreach (string numX in num)
if(Convert.ToInt32(Convert.ToString(numX)) > 0) count = count + 1;
else count = count * 1;
Console.Write($"Чисел больше 0 пользователь ввел: {count}");*/
//Задача 43: Написать программу, которая на вход принимает массив из любого количества 
//элементов (не менее 6) в промежутке от 0 до 100, а на выходе выводит этот же массив, 
//но отсортированный по возрастанию(от меньшего числа к большему).
int[] arr = GetArray(8);
Console.WriteLine($"{String.Join(" ", arr)}");
//Method--------------------------------------------------------
int[] GetArray(int size)
{
 int[] arr = new int[size];
for (int i = 0; i < size; i++)
{
    arr[i] = new Random().Next(101);
}
return arr;
}
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
SelectionSort(arr);
Console.WriteLine($"{String.Join(" ", arr)}");



