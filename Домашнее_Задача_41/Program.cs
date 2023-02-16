// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
//больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
// можно через строки ввести (ввести через split, вывести через join)


Console.WriteLine("Введите числа через пробел: ");
string N = Convert.ToString(Console.ReadLine());
string[] nums = N.Split(new char []{' '}, System.StringSplitOptions.RemoveEmptyEntries);
int count = 0;

foreach (var item in nums)
{
    int num = Convert.ToInt32(item);
    if (num > 0)
    {
       count++;
    }
}
Console.WriteLine($"Количество положительных чисел = {count}");