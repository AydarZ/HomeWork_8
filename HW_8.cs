// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int GetNumber(string message)
// {
//     System.Console.WriteLine("Введите " + message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// void FillArray(int[,] array)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = rnd.Next(1, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(string.Format("{0,5}", array[i, j] + " "));
//         }
//         System.Console.WriteLine();
//     }
// }

// void SortArray (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1) - 1; j++)
//         {
//             for (int k = j; k < array.GetLength(1); k ++)
//             {
//                 if (array[i,j] < array [i,k])
//                 {
//                     int temp = array [i,k];
//                     array [i,k] = array[i,j];
//                     array[i,j] = temp;
//                 }
//             }
//         }
//     }
// }

// int rows = GetNumber("количество строк массива");
// int columns = GetNumber("количество столбцов массива");
// int[,] Array = new int[rows, columns];
// FillArray(Array);
// PrintArray(Array);
// SortArray(Array);
// System.Console.WriteLine("Измененный массив:");
// PrintArray(Array);





// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int GetNumber(string message)
// {
//     System.Console.WriteLine("Введите " + message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// void FillArray(int[,] array)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = rnd.Next(1, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(string.Format("{0,5}", array[i, j] + " "));
//         }
//         System.Console.WriteLine();
//     }
// }

// int FindRowWithMinimalSummOfElements(int[,] array)
// {
//     int[] newArray = new int[array.GetLength(0)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int summ = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             summ += array[i, j];
//         }
//         System.Console.WriteLine("сумма элементов " + (i + 1) + " строки равна: " + summ);
//         newArray[i] = summ;
//     }

//     int min = 0;
//     for (int i = 0; i < newArray.Length - 1; i++)
//     {
//         if (newArray[i + 1] < newArray[i])
//         {
//             min = i + 1;
//         }
//     }
//     return min + 1;
// }

// int rows = GetNumber("количество строк массива");
// int columns = GetNumber("количество столбцов массива");
// int[,] Array = new int[rows, columns];
// FillArray(Array);
// PrintArray(Array);
// int RowWithMinimalSummOfElements = FindRowWithMinimalSummOfElements(Array);
// System.Console.WriteLine("Номер строки с наименьшей суммой элементов: " + RowWithMinimalSummOfElements + " строка");





// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int GetNumber(string message)
// {
//     System.Console.WriteLine("Введите " + message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// void FillArray(int[,] array)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = rnd.Next(1, 4);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(string.Format("{0,5}", array[i, j] + " "));
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// void MatrixMultiplication(int[,] array1, int[,] array2)
// {
//     if (array1.GetLength(1) == array2.GetLength(0))
//     {
//         int[,] newArray = new int[array1.GetLength(0), array2.GetLength(1)];
//         for (int j = 0; j < newArray.GetLength(1); j++)
//         {
//             for (int i = 0; i < newArray.GetLength(1); i++)
//             {
//                 for (int k = 0; k <= array1.GetLength(1) - 1; k++)
//                 {
//                     newArray[i, j] += array1[i, k] * array2[k, j];
//                 }
//             }
//         }
//         System.Console.WriteLine("Результирующая матрица:");
//         PrintArray(newArray);
//     }
//     else System.Console.WriteLine("данные матрицы невозможно умножить");
// }

// int rows1 = GetNumber("количество строк первой матрицы");
// int columns1 = GetNumber("количество второй матрицы");
// int[,] Array1 = new int[rows1, columns1];
// FillArray(Array1);
// PrintArray(Array1);
// int rows2 = GetNumber("количество строк второй матрицы \n(примечание: количество строк второй матрицы должно быть равно количеству столбцов первой матрицы)");
// int columns2 = GetNumber("количество второй матрицы ");
// int[,] Array2 = new int[rows2, columns2];
// FillArray(Array2);
// PrintArray(Array2);
// MatrixMultiplication(Array1, Array2);




// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int GetNumber(string message)
// {
//     System.Console.WriteLine("Введите " + message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// void FillArrayWithRandomNumbers(int[] array) //Заполняем одномерный массив случайными, неповторяющимися двузначными числами
// {
//     Random rnd = new Random();
//     array[0] = rnd.Next(10, 100);
//     for (int i = 1; i < array.Length; i++)
//     {
//         array[i] = rnd.Next(10, 100);
//         for (int j = 0; j < i; j++)
//             while (array[i] == array[j])
//             {
//                 array[i] = rnd.Next(10, 100);
//                 j = 0;
//             }
//     }
//     }

// void FillArray(int[,,] array)
// {
//     int[] NumbersToFillArray = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)]; 
//     FillArrayWithRandomNumbers(NumbersToFillArray);
//     System.Console.WriteLine("Чиcла для заполнения массива: " + string.Join(",", NumbersToFillArray) + "\n");
//     int count = 0; // индекс значения из одномерного массива
//     int number = NumbersToFillArray[count];
//     for (int k = 0; k < array.GetLength(2); k++)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 array[i, j, k] = number;
//                 count++;
//                 if (count == NumbersToFillArray.Length) return; // что бы не вылететь за пределы одномерного массива
//                 number = NumbersToFillArray[count];
//             }
//         }
//     }
// }

// void PrintArray(int[,,] array)
// {
//     for (int k = 0; k < array.GetLength(2); k++)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 System.Console.Write(string.Format("{0,13}", array[i, j, k] + $"{(i, j, k)}" + " "));
//             }
//             System.Console.WriteLine();
//         }

//     }
// }

// int rows = GetNumber("количество строк массива");
// int columns = GetNumber("количество столбцов массива");
// int z = GetNumber("количество этажей массива");
// int[,,] Array = new int[rows, columns, z];
// FillArray(Array);
// PrintArray(Array);







// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int GetNumber(string message)
{
    System.Console.WriteLine("Введите " + message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArraySpirally(int[,] array)
{
    int digit = 1;
    int length = array.GetLength(1);
    int width = array.GetLength(0);
    for (int i = 0; i < width; i++)
    {
        for (int j = i; j < length; j++) // заполняем, двигаясь вправо
        {
            array[i, j] = digit;
            digit++;
        }
        for (int k = i + 1, j = length - 1; k < width; k++) // заполняем, двигаясь вниз
        {
            if (array[k, j] == 0) //проверка: нет ли снизу заполненных значений
            {
                array[k, j] = digit;
                digit++;
            }
            else return;
        }
        length--;
        for (int k = width - 1, j = length - 1; j >= 0 + i; j--) // заполняем, двигаясь влево
        {
            if (array[k, j] == 0) //проверка: нет ли слева заполенных значений
            {
                array[k, j] = digit;
                digit++;
            }
            else return;
        }
        width--;
        for (int k = width - 1, j = 0 + i; k > i; k--) // заполняем, двигаясь вверх
        {
            if (array[k, j] == 0) //проверка: нет ли сверху заполненных значений
            {
            array[k, j] = digit;
            digit++;
            }
            else return;
        }

    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j]<10)  System.Console.Write(string.Format("{0,5}", "0" + array[i, j] + " "));
            else System.Console.Write(string.Format("{0,5}", array[i, j] + " "));
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}



int rows = GetNumber("количество строк массива");
int columns = GetNumber("количество столбцов массива");
int[,] Array = new int[rows, columns];
FillArraySpirally(Array);
PrintArray(Array);
