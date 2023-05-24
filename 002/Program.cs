// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
            // arr[i, j] = new Random().Next(0,10);
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

int FindMinString(int[,] arr) //Функция возвращает строку с наименьшей суммой элементов
{
    int temp = 0;
    int preSum = 999999;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i,j];
        }
        if (sum < preSum) 
        {
            temp = i;
            preSum = sum;
        }
    }

    return temp+1;
}

int [,] arr = CreateArray("Введите количество линий: ", "Введите количество столбцов: ");
FillArray(arr);
PrintArray(arr);
Console.WriteLine($"Строка с наименьшей суммой элементов: {FindMinString(arr)}");