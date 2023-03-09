﻿// // Задача 30: Напишите программу, которая 
// выводит массив из 8 элементов, заполненный 
// нулями и единицами в случайном порядке.
// // [1,0,1,1,0,1,0,0]


int Prompt()
{
    Console.WriteLine("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}

int size = Prompt();

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0,2);
    }
    return array;

}


int[] newarray = CreateArray(size);

Console.WriteLine($"[{String.Join(", ", newarray)}]");


