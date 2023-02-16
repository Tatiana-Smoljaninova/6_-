// Задача 42. Напишите прогр, кот будет преобразовывать десятичное число в двоичное
//45 - 101101
//3 - 11
//2 - 10

Console.WriteLine("Напишите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int n = 0; // вводим размер массива
int i = 0; // вводим номер индекса числа  массива
int[] array = new int[n]; // определили массив целых чисел, который будем заполнять

if (number == 1)
{
    n++; // увеличиваем размер массива на 1
    array[i] = 1;
    Console.WriteLine($"{array[i]} ");
}
else if (number > 1)
{
    n++; // увеличиваем размер массива на 1
    if (number % 2 > 0)
    {
       array[i] = 1; 
    }
    else if (number % 2 == 0)
    {
        array[i] = 0;
    }
    i++;
    number = number/2;
}
Console.WriteLine($"{array[i]} ");