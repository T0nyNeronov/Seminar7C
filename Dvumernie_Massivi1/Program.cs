// Задайте двумерный массив размером MxN, 
// заполненный случайными целыми числами.
// m = 3, n = 4
// 1 4 8 19 
// 5 -2 33 -2
// 77 3 8 1

Console.WriteLine("Введите количество строк ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int[rows,columns];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i,j] = new Random().Next(0,12);
        Console.Write(matrix[i,j]+" ");
    }
    Console.WriteLine();
}
