// Задача 47. Задайте двумерный массив размером m x n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


        // int m = 3;
        // int n = 4;
    
        // double[,] array = new double[m, n];
        
        // Random random = new Random();
        
        // for (int i = 0; i < m; i++)
        // {
        //     for (int j = 0; j < n; j++)
        //     {
        //         double randomNumber = random.NextDouble() * (10 - (-10)) + (-10);
                
        //         array[i, j] = randomNumber;
        //     }
        // }
        
        // Console.WriteLine("Двумерный массив:");
        // for (int i = 0; i < m; i++)
        // {
        //     for (int j = 0; j < n; j++)
        //     {
        //         Console.Write(array[i, j] + " ");
        //     }
        //     Console.WriteLine();
        // }


//  Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном
// массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//     Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


        // int[,] array = new int[,]
        // {
        //     { 1, 4, 7, 2 },
        //     { 5, 9, 2, 3 },
        //     { 8, 4, 2, 4 }
        // };


        // Console.WriteLine("Введите позицию элемента:");
        // Console.Write("Строка: ");
        // int row = Int32.Parse(Console.ReadLine());
        // Console.Write("Столбец: ");
        // int column = Int32.Parse(Console.ReadLine());

        // if (row >= 0 && row < array.GetLength(0) && column >= 0 && column < array.GetLength(1))
        // {
        //     int element = array[row, column];
        //     Console.WriteLine("Значение элемента: " + element);
        // }
        // else
        // {
        //     Console.WriteLine("Такого элемента нет");
        // }



//  Задача 52.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
//  элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


        // int[,] array = new int[,]
        // {
        //     { 1, 4, 7, 2 },
        //     { 5, 9, 2, 3 },
        //     { 8, 4, 2, 4 }
        // };
        
        // int rows = array.GetLength(0);
        // int columns = array.GetLength(1);

        // int[] sumArray = new int[columns];

        // for (int i = 0; i < rows; i++)
        // {
        //     for (int j = 0; j < columns; j++)
        //     {
        //         sumArray[j] += array[i, j];
        //     }
        // }

        // for (int j = 0; j < columns; j++)
        // {
        //     double average = (double)sumArray[j] / rows;
        //     Console.WriteLine("Среднее арифметическое для столбца {0}: {1}", j + 1, average.ToString("F1"));
        // }
    
    
    
    
    
