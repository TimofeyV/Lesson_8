// Задача 58: Задайте два двумерных массива (от 0 до 10). 
// Напишите программу, которая будет находить произведение двух массивов (поэлементное).
// Например, даны 2 массива:
// 2 4
// 3 2
// -----
// 3 4
// 3 3
// Результирующая матрица будет:
// 6 16
// 9 6


int[,] CreateArray(string message1, string message2) // Создание массива + вывод сообщений
{
    Console.Write(message1);
    int lines = Convert.ToInt32(Console.ReadLine());
    Console.Write(message2);
    int colums = Convert.ToInt32(Console.ReadLine());
    int[,] arr = new int[lines, colums];
    return arr;
}

void FillArray(int[,] arr) // Заполнение массива
{
    int count = 1;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {   
            //Можно сделать заполнение случайными числами, 
            //для этого строку ниже раcкоментить, остальное закоментировать
            //arr[i, j] = new Random().Next(0,10);
            Console.Write($"Введите значение для элемента {count}: ");
            count++;
            int temp = Convert.ToInt32(Console.ReadLine());
            arr[i,j] = temp;
        }
    }
}

void PrintArray(int[,] arr) // Вывод массива в терминал
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] MultiplyArrays(int[,] arr1, int[,] arr2) // Перемножение массивов поэлементно
{
    int[,] result_arr = new int[arr1.GetLength(0), arr1.GetLength(1)];

    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            result_arr[i,j] = arr1[i,j] * arr2[i,j];
        }
    }
    return result_arr;
}

int [,] arr1 = CreateArray("Введите количество линий для массива: ", "Введите количество столбцов для массива: ");
int [,] arr2 = new int[arr1.GetLength(0), arr1.GetLength(1)]; //Создание второго массива по размерам, заданным для первого

FillArray(arr1);
FillArray(arr2);

PrintArray(arr1);
Console.WriteLine("----------");
PrintArray(arr2);

Console.WriteLine("Результирующая матрица: ");
int [,] result_arr = MultiplyArrays(arr1, arr2);
PrintArray(result_arr);