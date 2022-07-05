void FillArrayDouble (double[,] currentArray)
{
    Random rand = new Random();
    for (int i = 0; i < currentArray.GetLength(0); i++)
    {
        for (int j = 0; j < currentArray.GetLength(1); j++)
        {
            currentArray[i, j] = Math.Round(rand.NextDouble() + rand.Next(-9, 10), 1);
        }
    }
}
void PrintArrayDouble (double[,] currentArray)
{
    for (int i = 0; i < currentArray.GetLength(0); i++)
    {
        for (int j = 0; j < currentArray.GetLength(1); j++)
        {
            Console.Write(currentArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void Task47()
{
// Задача 47: Задайте двумерный массив размером m×n, заполненный 
// случайными вещественными числами, округлёнными до одного знака.
Console.WriteLine("Задача № 47");
Console.WriteLine("=========================================");
double[,] array1 = new double[4,5];
FillArrayDouble(array1);
PrintArrayDouble(array1);
}

void Task50()
{
// Задача 50: Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Задача № 50");
Console.WriteLine("=========================================");
int row;
int column;
double[,] array = new double[4,5];
FillArrayDouble(array);
PrintArrayDouble(array);
Console.WriteLine("Введите номер строки");
row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (row < array.GetLength(0) && column < array.GetLength(1))
{
    Console.WriteLine("Искомый элемент: " + array[row-1, column-1]);
}
else
{
    {
       Console.WriteLine("Искомый элемент не найден"); 
    }
}
}

void Task52()
{
// Задача 52: Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Задача № 52");
Console.WriteLine("=========================================");
double[,] array = new double[4,5];
FillArrayDouble(array);
PrintArrayDouble(array);
Console.WriteLine("=========================================");
   for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        sum /= array.GetLength(0);
        Console.WriteLine($"Для {j+1} строки среднее арифметическое равно " + Math.Round(sum, 2));
        Console.WriteLine();
    }
}

// Task47();
// Task50();
// Task52();


