void Zadacha54()
{
    //Задача 54: Задайте двумерный массив. Напишите программу, 
    //которая упорядочит по убыванию элементы каждой строки двумерного массива.
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] array = new int[rows, columns];

    void FillArray(int[,] array)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = new Random().Next(0, 10);
            }
        }
    }
    FillArray(array);
    void PrintArray(int[,] array)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine("");
        }
    }
    PrintArray(array);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns - 1; j++)
        {
            for (int k = 0; k < columns - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }
            }
        }
    }
    Console.WriteLine();
    PrintArray(array);
}

void Zadacha56()
{
    //Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
    //которая будет находить строку с наименьшей суммой элементов.
    /*Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    5 2 6 7
    Программа считает сумму элементов в каждой строке и 
    выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] array = new int[rows, columns];
    void FillArray(int[,] array)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = new Random().Next(0, 10);
            }
        }
    }
    FillArray(array);
    void PrintArray(int[,] array)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine("");
        }
    }
    PrintArray(array);

    int minSum = 0;
    int sum = SumElements(array, 0);
    for (int i = 1; i < rows; i++)
    {
        int tempSum = SumElements(array, i);
        if (sum > tempSum)
        {
            sum = tempSum;
            minSum = i;
        }
    }
    Console.WriteLine($"\n{minSum + 1} - строкa с наименьшей суммой ({sum}) элементов ");
    int SumElements(int[,] array, int i)
    {
        int sum = array[i, 0];
        for (int j = 1; j < columns; j++)
        {
            sum += array[i, j];
        }
        return sum;
    }
}


void Zadacha58()
{
    //Задача 58. Заполните спирально массив 4 на 4.

}

//Zadacha54();
Zadacha56();
//Zadacha58();