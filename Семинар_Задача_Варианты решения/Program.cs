// int[] nums = {1, 2, 3, 4, 5, 6, 7, 8, 9 };

// foreach (var item in nums)
// {
//     Console.WriteLine(item);
// }


// int[,] nums2 = {{1, 2, 3 }, {4, 5, 6}, {7, 8, 9 }, {0, 4, 2}};

// foreach (var item in nums2)
// {
//     Console.WriteLine(item);
// }

// int[,] nums3 = new int[4, 3];

int[,] nums2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 0, 4, 2 } };

for (int i = 0; i < nums2.GetLength(0); i++) // этот цикл будет пробегаться по строкам
{
    for (int j = 0; j < nums2.GetLength(1); j++) // этот цикл будет пробегаться по столбцам
    {
        Console.Write($"{nums2[i, j]} ");
    }
    Console.WriteLine();
}