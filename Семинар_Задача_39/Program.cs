// Задача 39. Напишите прогр, кот перевернет одномерный массив (послед эл-т будет 
//на первом месте, а первый - на последнем и т.д.)
//[1 2 3 4 5] [5 4 3 2 1]
//[6 7 3 6 ] [6 3 7 6]

int[] array = new int[5];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,10);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
    if (i < array.Length/2)
    {
        int temp = array[i]; // запомни i
        array[i] = array[array.Length-1-i];
        array[array.Length-1-i] = temp;
    }
    Console.Write($"{array[i]} ");
}