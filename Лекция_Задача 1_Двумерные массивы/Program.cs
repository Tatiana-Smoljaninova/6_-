string[,] table = new string[2,5]; // размерность: 2 строки и 5 столбцов
//string.Empty - по умолчанию строки инициализируются пустые
// table[0,0] - первый элемент таблицы (1 строка, 1 столбец - по индексам)
// table[1,0] - вторая строка 1 столбец (вертикальное заполнение)
// table[0,1] - первая строка 2 столбец // table[1,1] 2 строка 2 столбец
// table[0,2] - первая строка 3 столбец // table[1,2] 2 строка 3 столбец
// table[0,3] - первая строка 4 столбец // table[1,3] 2 строка 4 столбец
// table[0,4] - первая строка 5 столбец // table[1,4] 2 строка 5 столбец

// table[1,2] = "слово"; // 1 - индекс строки, 2 индекс столбца
// //распечатаем данный массив со строковыми значениями
// for (int rows = 0; rows < 2; rows++) // rows - название счетчика строк
// {
//     for (int columns = 0; columns < 5; columns++) // colums - название счетчика колонок
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }


void PrintArray(int[,] matr) // метод, кот в качестве аргумента принимает таблицу
                            // чисел и будет ее печатать на экран
{
    for (int i = 0; i < matr.GetLength(0); i++)
    //в качестве аргумента GetLength передем (0) - это кол-во строк (rows)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine(); //переход на новую строку после заполнения каждого столбца
    }
}

void FillArray(int[,] matr) // метод, кот б. заполнять матрицу случайными числами
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
           matr[i, j] = new Random().Next(1,10);
        }
    }
}

int[,] matrix = new int[3,4];
PrintArray(matrix);// вывод на печать матрицы
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);