﻿// Задача 40. Напишите прогр, кот принимает на вход три числа и проверяет, 
//может ли существовать треугольник со сторонами такой длинны
//(теорема о неравенстве треугольника: кажд сторона треугольника меньше суммы двух
// других сторон)

int[] array = {11, 11, 16};
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(1,10);
//     Console.Write($"{array[i]} ");
// }

if 
(array[0] < (array[1] + array[2])
& array[1] < (array[0] + array[2])
& array[2] < (array[1]+array[0]))
{
    Console.WriteLine("Такой треугольник может существовать");
}
else Console.WriteLine("Такой треугольник не может существовать");