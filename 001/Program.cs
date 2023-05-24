// Задача 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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

void DecreaseOrder(int[,] arr)//Сортировка строк по убыванию
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
            int temp;
            for(int f = 0; f < arr.GetLength(1); f++)//Количество проходов == длине строки, т.к. за один проход сортировка может не выполнится
            {
                for (int j = 1; j < arr.GetLength(1); j++)
                {
                    if (arr[i,j] > arr[i,j-1])
                    {
                        temp = arr[i,j];
                        arr[i,j] = arr[i,j-1];
                        arr[i,j-1] = temp;
                    }
                }
            }
    }
}

int [,] arr = CreateArray("Введите количество линий: ", "Введите количество столбцов: ");
FillArray(arr);
PrintArray(arr);
DecreaseOrder(arr);
Console.WriteLine("Отсортированный массив: ");
PrintArray(arr);