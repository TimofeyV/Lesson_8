// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] CreateArray(string message1, string message2, string message3) // Создание массива + вывод сообщений
{
    Console.Write(message1);
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write(message2);
    int y = Convert.ToInt32(Console.ReadLine());
    Console.Write(message3);
    int z = Convert.ToInt32(Console.ReadLine());
    int[,,] arr = new int[x, y, z];
    return arr;
}

void FillArray(int[,,] array3D) //Заполнение массива уникальными двузначными числами
{
    int[] array = new int [array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];

    for (int i = 0; i < array.Length; i++)//Создание одномерного массива с уникальными числами
    {
        int temp = new Random().Next(10,100);

        if (array.Contains(temp)) i--;
        else array[i] = temp;  
    }

    int count = 0;
    for (int x = 0; x < 2; x++)//Из массива, созданного выше, записываю числа в трёхмерный массив
    {
        for (int y = 0; y < 2 ; y++)
        {
            for (int z = 0; z < 2; z++)
            {
               array3D[x, y, z] = array[count];
               count++;
            }  
        }
    }         
}

void PrintArray(int[,,] arr) // Вывод массива в терминал
{
   for (int x = 0; x < 2; x++)
    {
        for (int y = 0; y < 2 ; y++)
        {
            for (int z = 0; z < 2; z++)
            {
               Console.Write(arr[x, y, z] + $" ({x},{y},{z}) ");
            }
            Console.WriteLine();
        }
    }             
}

int [,,] array3D = CreateArray("Введите X: ", "Введите Y: ", "Введите Z: ");
FillArray(array3D);
PrintArray(array3D);
