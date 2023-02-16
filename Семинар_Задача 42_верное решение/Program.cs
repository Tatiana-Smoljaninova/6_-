// Задача 42. Напишите прогр, кот будет преобразовывать десятичное число в двоичное
//45 - 101101
//3 - 11
//2 - 10

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string result = "";
while (number > 0)
{
    result = Convert.ToString(number % 2) + result;
    number /= 2; // number = number / 2
}
Console.WriteLine(result);
